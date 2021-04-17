﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CaseOpener
{
    class User
    {

        int _userID;
        float _balance;
        List<Item> _inventory;

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

        public User(int id)
        {
            _userID = id;
            _balance = 0;
            _inventory = new List<Item>();
        }

        public float addBalance(float amount)
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
