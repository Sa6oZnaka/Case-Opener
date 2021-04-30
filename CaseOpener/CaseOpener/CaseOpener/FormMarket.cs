using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaseOpener
{
    public partial class FormMarket : Form
    {
        public FormMarket()
        {
            InitializeComponent();

            listView1.View = View.Details;


            listView1.Items.Add(new ListViewItem(new string[] { "kiselo zele", "kat novo", "bai mincho", "100" }));
        }

        private void listViewListings_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
