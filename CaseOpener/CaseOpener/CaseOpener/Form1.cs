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
                    _game.removeItem(_userID, selectedItem);

                }
                RefreshListBoxItems();


            }
            
        }

    }
}
