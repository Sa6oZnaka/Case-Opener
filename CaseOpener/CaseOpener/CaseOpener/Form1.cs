using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseOpener
{
    public partial class Form1 : Form
    {

        private Game _game = new Game();
        private int _userID = 0;

        public Form1()
        {
            _game.addUser("test");
            

            InitializeComponent();

            login();
        }

        private void ItemChange()
        {
            RefreshListBoxItems();
        }

        private void RefreshListBoxItems()
        {
            listBoxItems.Items.Clear();
            //listBoxItems.Items.AddRange(_phoneBook.Find(textBoxNameSearch.Text));
            listBoxItems.Items.AddRange(_game.getUserItems(0).ToArray());

            listBoxItems.DrawMode = DrawMode.OwnerDrawVariable;
            listBoxItems.DrawItem += new DrawItemEventHandler(listBoxItems_DrawItem);

        }

        void listBoxItems_DrawItem(object sender, DrawItemEventArgs e)

        {

            if (e.Index < 0)
                return;

            e.DrawBackground();
            e.DrawFocusRectangle();

            Color c = Color.Gray;

            GameItem selectedItem = null;
            if (listBoxItems.Items[e.Index].GetType().Name == "GameItem")
            {
                selectedItem = (GameItem)listBoxItems.Items[e.Index];
                c = selectedItem.Color;
            }

            e.Graphics.DrawString(listBoxItems.Items[e.Index].ToString(), new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), new SolidBrush(c), e.Bounds);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            _game.addItem(0, ItemFactory.regullarCase);

            RefreshListBoxItems();
        }

        private void listBoxItems_DoubleClick(object sender, EventArgs err)
        {

            if (listBoxItems.SelectedItem == null)
            {
                return;
            }

            if (listBoxItems.SelectedItem.GetType().Name == "Case")
            {
                Case c = null;
                try
                {
                    c = (Case)listBoxItems.SelectedItem;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Generic Exception Handler: {e}");
                    MessageBox.Show("Please select case!");
                    return;
                }

                if (MessageBox.Show(
                    "Are you sure?",
                    "Confirm open",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)

                    if (_game.removeItem(_userID, c))
                    {

                        GameItem item = c.open();
                        _game.addItem(_userID, item);
                        RefreshListBoxItems();
                        //new FormGameItem(item.Name, item.Wear.Value).ShowDialog();
                    }
            }else if(listBoxItems.SelectedItem.GetType().Name == "GameItem")
            {

                GameItem selectedItem = (GameItem)listBoxItems.SelectedItem;

                var fp = new FormGameItem(selectedItem.Name, selectedItem.Wear.Value);

                if (fp.ShowDialog() == DialogResult.OK)
                {
                    if (Double.TryParse(fp.TextBoxPrice, out double result))
                        _game.createListing(_userID, selectedItem, result);
                    else
                        MessageBox.Show("Incorect price!");


                }
                RefreshListBoxItems();


            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var fp = new FormMarket();
            fp.Listings = _game.Listings;
            fp.User = _game.getUser(_userID);
            var result = fp.ShowDialog();
            if (result == DialogResult.OK)
            {
                // BUY BUTTON
                if(fp.removeSelected() != null)
                    _game.removeListing(fp.removeSelected());
                else
                    MessageBox.Show("Please select at least 1 item!");

            }
        }

        private void buttonTradeup_Click(object sender, EventArgs e)
        {
            List<GameItem> selectedItems = new List<GameItem>();
            foreach (var item in listBoxItems.SelectedItems)
            {
                if(item.GetType().Name == "GameItem")
                    selectedItems.Add((GameItem)item);
            }
            if(selectedItems.Count == 10)
            {
                // check if the items are the same rarity
                int rarity = (int)selectedItems[0].Rarity;
                if(selectedItems.FindAll(i => (int)i.Rarity == rarity).Count() == 10)
                {
                    TradeUp trade = new TradeUp(selectedItems);
                    _game.compleateTradeup(_userID, trade);

                    RefreshListBoxItems();
                }
                else
                    MessageBox.Show("Items need to be from the same rarity");

            }
            else
                MessageBox.Show("Please select 10 items");

        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            var fp = new FormFriends();
            fp.Friends = _game.getUser(_userID).Friends;
            if(fp.ShowDialog() == DialogResult.OK)
            {
                if(! _game.addFriend(_userID, fp.requestName))
                    MessageBox.Show("User not found!");
            }

        }

        private bool displayLoginForm()
        {
            var fp = new FormLogin();
            //fp.Friends = _game.getUser(_userID).Friends;

            var dialogResult = fp.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                User user = _game.getUser(fp.Name);
                if (user == null)
                {
                    MessageBox.Show("User not found!");
                    return false;
                }
                else
                {
                    getUserDetails(user);
                    return true;
                }
            }
            else
            {
                // check if user exists
                User user = _game.getUser(fp.Name);
                if (user == null)
                {
                    _game.addUser(fp.Name);
                    getUserDetails(_game.getUser(fp.Name));
                    return true;
                }
                else
                {
                    MessageBox.Show("User already exist!");
                    return false;
                }
            }
            
        }

        private void getUserDetails(User user)
        {
            _userID = user.UserID;
            labelName.Text += user.Name;
        }

        private void login()
        {
            while (!displayLoginForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // todo fix
            InitializeComponent();

            login();
        }
    }
}
