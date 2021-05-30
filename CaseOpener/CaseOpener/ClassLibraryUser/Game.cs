using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirm.CaseOpener.ClassLibraryUser
{
 
    [Serializable]
    public class Game
    {

        private List<User> _users;
        private List<Listing> _listings;
        private int _listingID;

        public Game()
        {
            _listingID = 0;
            _users = new List<User>();
            _listings = new List<Listing>();
        }

        public List<User> Users {
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
                return _listings;
            }
            set
            {
                _listings = value;
            }
        }

        public User getUser(int id)
        {
            return _users[id];
        }

        public User getUser(string name)
        {
            var available = _users.FindAll(u => u.Name == name);
            if (available.Count != 1)
                return null;

            return available[0];
        }

        // id of sender
        public bool addFriend(int id, string name)
        {


            List<User> selected = _users.FindAll(u => u.Name == name);
            if (selected.Count != 1)
                return false;

            int receaverID = selected[0].UserID;

            string senderName = _users[id].Name;
            _users[receaverID].Friends.Add(new FriendRequest(id, receaverID, senderName));
           
            return true;
        }

        public bool removeListing(Listing listing)
        {
            return _listings.Remove(listing);
        }

        public void buyListing(int userID, Listing listing)
        {
            //if (removeListing(listing))
            //    addItem(userID, Listing.Item);
        }

        public bool removeBalance(int userID, double amount)
        {
            if(_users[userID].Balance >= amount)
            {
                _users[userID].Balance -= amount;
                return true;
            }
            return false;
        }

        public void addUser(string name)
        {
            _users.Add(new User(_users.Count, name));
        }
        
        public void addItem(int userID, Item item)
        {
            _users[userID].addItem(item);
        }

        public bool removeItem(int userID, Item item)
        {
            return _users[userID].removeItem(item);
        }

        public void createListing(int userID, Item item, double price)
        {
            if (this.removeItem(userID, item))
            {
                _listings.Add(new Listing(_listingID, userID, item, price));
                _listingID++;
            }
        }

        public List<Item> getUserItems(int id)
        {
            return _users[id].Inventory;
        }

        public void compleateTradeup(int userID, TradeUp tradeup)
        {
            foreach(Item item in tradeup.Items)
            {
                removeItem(userID, item);
            }
            _users[userID].addItem(tradeup.Compleate());
        }

    }
}
