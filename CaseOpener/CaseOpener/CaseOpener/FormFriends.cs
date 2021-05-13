using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaseOpener
{
    public partial class FormFriends : Form
    {

        private List<FriendRequest> _friends;
        private int _userID;

        public int UserID {
            get
            {
                return _userID;
            }
            set
            {
                _userID = value;
            }
        }

        public List<FriendRequest> Friends {
            get
            {
                return _friends;
            }
            set
            {
                _friends = value;
            }
        }

        public string requestName 
        {
            get
            {
                return textBoxUser.Text;
            }
            set
            {

            }
        }

        public FormFriends()
        {
            InitializeComponent();
        }

        private void showFriends(bool acceptedOnly)
        {
            listBoxFriends.Items.Clear();
            listBoxFriends.Items.Add("-----");
            foreach (var request in _friends)
            {
                listBoxFriends.Items.Add(request);

            }
        }

        private void button2_Click(object sender, EventArgs e) // button friends
        {
            showFriends(true);
        }

        private void buttonPending_Click(object sender, EventArgs e)
        {
            showFriends(false);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonSent_Click(object sender, EventArgs e)
        {

        }
    }
}
