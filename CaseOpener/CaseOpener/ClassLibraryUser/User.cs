﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirm.CaseOpener.ClassLibraryUser
{
    [Serializable]
    public class User
    {

        private string _name;
        private int _userID;
        private double _balance;
        private List<Item> _inventory;
        private List<FriendRequest> _friendList; // contains user Ids 
        private List<Offer> _tradeOffers;

        public List<Offer> Offers
        {
            get
            {
                return _tradeOffers;
            }
            set
            {
                _tradeOffers = value;
            }
        }


        public List<FriendRequest> Friends {
            get
            {
                return _friendList;
            }
            set
            {
                _friendList = value;
            } 
        }

        public string Name {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                _balance = value;
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

        public List<Item> Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public User(int id, string name)
        {
            _name = name;
            _userID = id;
            _balance = 250; // For testing!!!
            _inventory = new List<Item>();
            _friendList = new List<FriendRequest>();
            _tradeOffers = new List<Offer>();
        }

        public double addBalance(float amount)
        {
            return _balance += amount;
        }
        
        public void addItem(Item item)
        {
            _inventory.Add(item);
        }

        public bool removeItem(Item item)
        {
            return _inventory.Remove(item);
        }

    }
}
