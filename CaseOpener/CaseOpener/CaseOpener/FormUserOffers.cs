﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Offer = MyFirm.CaseOpener.ClassLibraryUser.Offer;
using User = MyFirm.CaseOpener.ClassLibraryUser.User;
using System.Linq;

namespace MyFirm.CaseOpener
{
    public partial class FormUserOffers : Form
    {
        private List<Offer> _offers;
        private List<User> _users;

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
            var result = fo.ShowDialog();
            if(result == DialogResult.Yes)
            {
                foreach (var item in from item in offer.Send
                                     where _users[offer.SenderID].removeItem(item)
                                     select item)
                    _users[offer.ReceaverID].addItem(item);
                

                foreach (var item in from item in offer.Receave
                                     where _users[offer.ReceaverID].removeItem(item)
                                     select item)
                    _users[offer.SenderID].addItem(item);
                

                _offers.Remove(offer);
            }
            else // offer declined (Dialogbox.No)
            {
                _offers.Remove(offer);
            }

        }

        private void FormUserOffers_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
