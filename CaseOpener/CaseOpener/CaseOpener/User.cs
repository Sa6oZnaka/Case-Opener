using System;
using System.Collections.Generic;
using System.Text;

namespace CaseOpener
{
    class User
    {

        private string _name;
        private int _userID;
        private float _balance;
        private List<Item> _inventory;
        private List<int> _friendList; // contains user Ids 
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
