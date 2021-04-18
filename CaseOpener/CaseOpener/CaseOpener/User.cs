using System;
using System.Collections.Generic;
using System.Text;

namespace CaseOpener
{
    class User
    {

        int _userID;
        float _balance;
        List<Item> _inventory;
        List<int> _friendList; // contains user Ids 
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

        public User(int id)
        {
            _userID = id;
            _balance = 0;
            _inventory = new List<Item>();
            _friendList = new List<int>();
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
