using System;
using System.Collections.Generic;
using System.Text;

namespace CaseOpener
{
    class Listing
    {

        private int _userID;
        private Item _item;
        private double _price;

        public Listing(int userID, Item item, double price)
        {
            _userID = userID;
            _item = item;
            _price = price;
        }

        public int UserID {
            get
            {
                return _userID;
            }
            set { }
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
