using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaseOpener
{
 
    [Serializable]
    class Game
    {

        private List<User> _users;
        private List<Offer> _tradeOffers;
        private List<Listing> _listings;
        private int _listingID;

        public Game()
        {
            _listingID = 0;
            _users = new List<User>();
            _tradeOffers = new List<Offer>();
            _listings = new List<Listing>();
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

        private void acceptFriendRequest(FriendRequest request)
        {
            request.accept();

            // ADD FRIEND FOR OTRHER
            //addFriend(request)
        }

        private void removeFriendRequest(FriendRequest request)
        {
            int senderID = request.getSender();
            _users[senderID].Friends.Remove(request);
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

        public List<Offer> getOffers(int userID)
        {
            return (List<Offer>)_tradeOffers.Select(t => t.ReceaverID == userID);
        }

        public List<Offer> getMyOffers(int userID)
        {
            return (List<Offer>)_tradeOffers.Select(t => t.SenderID == userID);
        }

        public bool removeOffer(Offer offer)
        {
            return _tradeOffers.Remove(offer);
        }

        public void addOffer(int sender, int receaver, List<Item> toSend, List<Item> toReceave)
        {
            _tradeOffers.Add(new Offer(sender, receaver, toSend, toReceave));
        }

        public void acceptOffer(Offer offer)
        {
            User sender = (User)_users.Select(u => u.UserID = offer.SenderID);
            User receaver = (User)_users.Select(u => u.UserID = offer.ReceaverID);

            for(int i = 0; i < offer.Send.Count; i++)
                if (sender.removeItem(offer.Send[i]))
                    receaver.addItem(offer.Send[i]);

            for (int i = 0; i < offer.Receave.Count; i++)
                if (receaver.removeItem(offer.Receave[i]))
                    sender.addItem(offer.Receave[i]);

            _tradeOffers.Remove(offer);
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
