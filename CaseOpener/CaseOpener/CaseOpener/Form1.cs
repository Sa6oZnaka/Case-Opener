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

            Case c = null;

            try
            {
                c = (Case)listBoxItems.SelectedItem;
            } catch (Exception e)
            {
                Console.WriteLine($"Generic Exception Handler: {e}");
                MessageBox.Show("Please select case!");
                return;
            }

            if (MessageBox.Show(
                "Are you sure?",
                "Confirm delete",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning) == DialogResult.OK)
            
                if(_game.removeItem(_userID, c))
                
                    _game.addItem(_userID, c.open());
                
            
            RefreshListBoxItems();

        }

    }
}
