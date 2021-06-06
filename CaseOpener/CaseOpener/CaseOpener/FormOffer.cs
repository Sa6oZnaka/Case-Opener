using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using GameItem = MyFirm.CaseOpener.ClassLibraryUser.GameItem;
using Item = MyFirm.CaseOpener.ClassLibraryUser.Item;
using Offer = MyFirm.CaseOpener.ClassLibraryUser.Offer;
using System.Linq;

namespace MyFirm.CaseOpener
{
    public partial class FormOffer : Form
    {

        private List<Item> _sendItems;
        private List<Item> _receavedItems;
        
        public List<Item> Send
        {
            get
            {
                return _sendItems;
            }
            set
            {
                _sendItems = value;
            }
        }
        public List<Item> Reaceave
        {
            get
            {
                return _receavedItems;
            }
            set
            {
                _receavedItems = value;
            }
        }

        public FormOffer(List<Item> send, List<Item> receave)
        {
            InitializeComponent();

            _sendItems = send;
            _receavedItems = receave;

            display();
        }

        public FormOffer(Offer offer)
        {
            InitializeComponent();

            _sendItems = offer.Send;
            _receavedItems = offer.Receave;

            buttonSendOffer.Text = "Accept Offer";
            buttonRemoveFriend.Text = "Decline Offer";

            listBoxReceave.DrawMode = DrawMode.OwnerDrawVariable;
            listBoxReceave.DrawItem += new DrawItemEventHandler(listBoxReceave_DrawItem);

            listBoxSend.DrawMode = DrawMode.OwnerDrawVariable;
            listBoxSend.DrawItem += new DrawItemEventHandler(listBoxSend_DrawItem);

            display();
        }

        void listBoxSend_DrawItem(object sender, DrawItemEventArgs e)

        {

            if (e.Index < 0)
                return;

            e.DrawBackground();
            e.DrawFocusRectangle();

            Color c = Color.Gray;

            GameItem selectedItem = null;
            if (listBoxSend.Items[e.Index].GetType().Name == "GameItem")
            {
                selectedItem = (GameItem)listBoxSend.Items[e.Index];
                c = selectedItem.Color;
            }

            e.Graphics.DrawString(listBoxSend.Items[e.Index].ToString(), new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), new SolidBrush(c), e.Bounds);

        }

        void listBoxReceave_DrawItem(object sender, DrawItemEventArgs e)

        {

            if (e.Index < 0)
                return;

            e.DrawBackground();
            e.DrawFocusRectangle();

            Color c = Color.Gray;

            GameItem selectedItem = null;
            if (listBoxReceave.Items[e.Index].GetType().Name == "GameItem")
            {
                selectedItem = (GameItem)listBoxReceave.Items[e.Index];
                c = selectedItem.Color;
            }

            e.Graphics.DrawString(listBoxReceave.Items[e.Index].ToString(), new Font(FontFamily.GenericSansSerif, 8, FontStyle.Bold), new SolidBrush(c), e.Bounds);

        }


        private void display()
        {
            foreach(var item in _sendItems)
            {
                listBoxSend.Items.Add(item);
            }
            foreach (var item in _receavedItems)
            {
                listBoxReceave.Items.Add(item);
            }
        }

        public List<Item> getSend()
        {
            List<Item> result = new List<Item>();
            if (listBoxReceave.Items.Count > 0)
                result.AddRange(from Item item in listBoxSend.SelectedItems
                                select item);
            return result;
        }

        public List<Item> getReceave()
        {
            List<Item> result = new List<Item>();
            if(listBoxReceave.Items.Count > 0)
                result.AddRange(from Item item in listBoxReceave.SelectedItems
                                select item);
            return result;
        }


    }
}
