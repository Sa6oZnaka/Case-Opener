using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseOpener
{
    public partial class FormMenu : Form
    {

        private Game _game = new Game();
        private int _userID;

        public FormMenu()
        {
            InitializeComponent();

            if (!File.Exists("data"))
            {
                return;
            }
            var formatter = new BinaryFormatter();
            using (var stream = new FileStream("data", FileMode.Open))
            {
                _game = (Game)formatter.Deserialize(stream);
            }

            listBoxItems.DrawMode = DrawMode.OwnerDrawVariable;
            listBoxItems.DrawItem += new DrawItemEventHandler(listBoxItems_DrawItem);
        }

        private void ItemChange()
        {
            RefreshListBoxItems();
        }

        private void RefreshListBoxItems()
        {
            listBoxItems.Items.Clear();
            /*listBoxItems.Items.AddRange(
                _game.getUserItems(_userID)
                .ToArray());*/

            foreach (var item in _game.getUserItems(_userID))
                if(item.Name.StartsWith(textBoxSearch.Text))
                    listBoxItems.Items.Add(item);
            
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
            if (_game.removeBalance(_userID, 2.5))
            {
                _game.addItem(_userID, ItemFactory.regullarCase);
                labelBalance.Text = "Balance: " + _game.getUser(_userID).Balance;
                RefreshListBoxItems();
            }
            else
            {
                MessageBox.Show("Insufficient funds! You need 2.50 to buy a case");
            }
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

                var fp = new FormGameItem(selectedItem);

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
            fp.Users = _game.Users;
            fp.User = _game.getUser(_userID);
            fp.Listings = _game.Listings;
            var result = fp.ShowDialog();
            // refresh after form is closed
            if (result == DialogResult.OK)
            {
                RefreshListBoxItems();
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
            fp.Users = _game.Users;
            if (fp.ShowDialog() == DialogResult.OK)
            {
                if(! _game.addFriend(_userID, fp.requestName))
                    MessageBox.Show("User not found!");
            }

        }

        public bool TryLogin(string username)
        {
       
                User user = _game.getUser(username);
                if (user == null)
                {
                    MessageBox.Show("User not found!");
                    return false;
                }
                else
                {
                    this.getUserDetails(user);
                    RefreshListBoxItems();
                    return true;
                }
        }

        public bool TryRegister(string username)
        {

            User user = _game.getUser(username);
            if (user == null)
            {
                _game.addUser(username);
                getUserDetails(_game.getUser(username));
                return true;
            }
            else
            {
                MessageBox.Show("User already exist!");
                return false;
            }

        }


        private void getUserDetails(User user)
        {
            _userID = user.UserID;
            labelName.Text += user.Name;
            labelBalance.Text += user.Balance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formatter = new BinaryFormatter();

            using (var stream = new FileStream("data", FileMode.Create))
            {
                formatter.Serialize(stream, _game);
            }
        }

        private void buttonOffers_Click(object sender, EventArgs e)
        {
            // open offers
            var fo = new FormUserOffers(_game.getUser(_userID).Offers);
            fo.Users = _game.Users;
            if (fo.ShowDialog() == DialogResult.OK)
            {
                RefreshListBoxItems();
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshListBoxItems();
        }
    }
}
