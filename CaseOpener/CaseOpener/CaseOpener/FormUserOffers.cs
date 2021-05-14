using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaseOpener
{
    public partial class FormUserOffers : Form
    {
        private List<Offer> _offers;

        public FormUserOffers(List<Offer> offers)
        {
            InitializeComponent();

            _offers = offers;
            displayOffers();
        }

        private void displayOffers()
        {
            foreach(var offer in _offers)
            {
                listBoxOffers.Items.Add(offer);
            }
        }

        private void listBoxOffers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxOffers.SelectedItem == null)
                return;

            // open offer
            Offer offer = (Offer)listBoxOffers.SelectedItem;
            var fo = new FormOffer(offer);
            fo.ShowDialog();


        }
    }
}
