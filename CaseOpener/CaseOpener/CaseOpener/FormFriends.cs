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
        private List<User> _users;
        private int _userID;

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

                showFriends(true);
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
            foreach (var request in _friends)
            {
                if (acceptedOnly && request.getStatus() == 1)
                    listBoxFriends.Items.Add(request);
                else if (!acceptedOnly && request.getStatus() == 0 && request.getSender() != _userID)
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

        private void listBoxFriends_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxFriends.SelectedItem == null)
            {
                return;
            }

            FriendRequest fr = (FriendRequest)listBoxFriends.SelectedItem;
            if (fr.getStatus() == 0)
            {
                if (MessageBox.Show(
                        "Do you want to accept?",
                        "Confirm accept",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    MessageBox.Show("Accepted!");
                    fr.accept();

                    // Add friend to the sender
                    FriendRequest senderRequest = new FriendRequest(
                            fr.getReceaver(),
                            fr.getSender(),
                            _users[fr.getReceaver()].Name);

                    senderRequest.accept();
                    _users[fr.getSender()].Friends.Add(senderRequest);

                    showFriends(false);
                }
                else
                {
                    MessageBox.Show("Deleted!");
                    _friends.Remove(fr);
                }
            }
            else
            {
                // Already a friend
                User receaver = _users[fr.getReceaver()];


                var fo = new FormOffer(receaver.Inventory, _users[fr.getSender()].Inventory);
                var result = fo.ShowDialog();
                if(result == DialogResult.Yes)
                {
                    // send trade offer
                    List<Item> tmp = new List<Item>();

                    _users[fr.getSender()].Offers.Add(
                        new Offer(fr.getSender(), fr.getReceaver(), fo.getReceave(), fo.getSend()));

                    /*
                    receaver.Offers.Add(
                        new Offer(
                            fr.getReceaver(), 
                            fr.getSender(), 
                            fo.getSend(), 
                            fo.getReceave()));*/

                }
                else if (result == DialogResult.No)
                {
                    // remove friend

                }
            }

        }
    }
}
