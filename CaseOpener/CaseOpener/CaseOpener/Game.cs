using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaseOpener
{
    class Game
    {

        List<User> _users;
        List<Offer> _tradeOffers;
        List<Listing> _listings;

        public Game()
        {
            _users = new List<User>();
            _tradeOffers = new List<Offer>();
            _listings = new List<Listing>();
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
            if(this.removeItem(userID, item))
                _listings.Add(new Listing(userID, item, price));
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
                _users[userID].removeItem((Item)_users[userID].Inventory.Select(i => i.ID = item.ID));
            }
            _users[userID].addItem(tradeup.Compleate());
        }

    }
}
