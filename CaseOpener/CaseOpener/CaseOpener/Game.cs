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


        Game()
        {
            _users = new List<User>();
            _tradeOffers = new List<Offer>();
        }
        void addUser()
        {
            _users.Add(new User(_users.Count));
        }
        
        List<Offer> getOffers(int userID)
        {
            return (List<Offer>)_tradeOffers.Select(t => t.ReceaverID == userID);
        }

        List<Offer> getMyOffers(int userID)
        {
            return (List<Offer>)_tradeOffers.Select(t => t.SenderID == userID);
        }

        bool removeOffer(Offer offer)
        {
            return _tradeOffers.Remove(offer);
        }

        void addOffer(int sender, int receaver, List<Item> toSend, List<Item> toReceave)
        {
            _tradeOffers.Add(new Offer(sender, receaver, toSend, toReceave));
        }

        void acceptOffer(Offer offer)
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


    }
}
