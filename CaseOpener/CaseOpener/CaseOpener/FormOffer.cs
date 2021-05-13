using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaseOpener
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

    }
}
