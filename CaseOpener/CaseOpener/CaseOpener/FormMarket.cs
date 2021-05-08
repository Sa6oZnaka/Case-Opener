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
                listView1.Items.Add(new ListViewItem(
                    new string[] {
                        _availableListings[i].ID.ToString(),
                        _availableListings[i].Item.Name, 
                        "Rarity",
                        "kat novo" , 
                        "bai mincho", 
                        _availableListings[i].Price.ToString() 
                    }));
            }
        }

        public Listing removeSelected()
        {
            // TODO 
            if (listView1.SelectedItems.Count == 0)
                return null;

            
            ListViewItem selected = listView1.SelectedItems[0];
            string idString = selected.SubItems[0].Text;
            int id = int.Parse(idString);

            Listing l = _availableListings.FindAll(l => l.ID == id)[0];

            _availableListings.Remove(l);

            refreshListings();

            return null;
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
    }
}
