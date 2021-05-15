using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaseOpener
{
    partial class FormMarket : Form
    {
        private List<Listing> _availableListings = new List<Listing>();
        private User _user = null;
        private List<User> _users = new List<User>();


        public List<User> Users 
        {
            get
            {
                return _users;
            }
            set
            {
                _users = value;
            }
        }

        public List<Listing> Listings {
            get
            {
                return _availableListings;
            }
            set
            {
                _availableListings = value;

                refreshListings();
            }
        }

        public User User {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            } 
        }


        public FormMarket()
        {
            InitializeComponent();

            listView1.View = View.Details;
        }

        private void refreshListings()
        {
            listView1.Items.Clear();

            for(int i = 0; i < _availableListings.Count; i ++)
            {
                if (_availableListings[i].Item.Name.StartsWith(textBoxSearch.Text))
                {
                    GameItem item = (GameItem)_availableListings[i].Item;

                    listView1.Items.Add(new ListViewItem(
                        new string[] {
                            _availableListings[i].ID.ToString(),
                            item.Name,
                            item.Rarity.ToString(),
                            item.Wear.ToString(),
                            _users[_availableListings[i].UserID].Name,
                            _availableListings[i].Price.ToString()
                        }));
                }
            }
        }
        public bool removeSelected()
        {
            // TODO 
            if (listView1.SelectedItems.Count == 0)
                return false;

            
            ListViewItem selected = listView1.SelectedItems[0];
            string idString = selected.SubItems[0].Text;
            int id = int.Parse(idString);

            Listing l = _availableListings.FindAll(l => l.ID == id)[0];

            // remove own listing
            if(_user.UserID == l.UserID)
            {
                _user.addItem(l.Item);
                _availableListings.Remove(l);
                refreshListings();
                return true;
            }

            if (_user.Balance >= l.Price)
            {
                // add to other user balance

                _user.Balance -= l.Price;
                _users[l.UserID].Balance += l.Price;

                _user.addItem(l.Item);

                _availableListings.Remove(l);

                refreshListings();
                return true;
            }

            return false;
        }



        private void listViewListings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            removeSelected();
        }

        private void FormMarket_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            refreshListings();
        }
    }
}
