using System;
using System.Collections.Generic;
using System.Text;

namespace CaseOpener
{
    [Serializable]
    class Listing
    {

        private int _id;
        private int _userID;
        private Item _item;
        private double _price;
        public int ID
        {
            get
            {
                return _id;
            }
            set { }
        }

        public Listing(int id, int userID, Item item, double price)
        {
            _id = id;
            _userID = userID;
            _item = item;
            _price = price;
        }

        public int UserID {
            get
            {
                return _userID;
            }
            set {
                _userID = value;
            }
        }

        public Item Item
        {
            get
            {
                return _item;
            }
            set { }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set 
            {
                _price = value;
            }
        }


    }
}
