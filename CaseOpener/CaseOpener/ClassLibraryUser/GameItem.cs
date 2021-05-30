using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MyFirm.CaseOpener.ClassLibraryUser
{
    [Serializable]
    public class GameItem : Item
    {

        private double? _wear;
        private double _minWear;
        private double _maxWear;
        private string _imageURL;

        RarityEnum.Rarity _rarity;

        public double? MinWear
        {
            get
            {
                return _minWear;
            }
            set{}
        }

        public double? MaxWear
        {
            get
            {
                return _maxWear;
            }
            set{}
        }


        public double? Wear {
            get
            {
                return _wear;
            }
            set
            {
                _wear = value;
            }
        }

        public string ImageURL 
        {
            get
            {
                return _imageURL;
            }
            set
            {
                _imageURL = value;
            }
        }

        public RarityEnum.Rarity Rarity { 
            get {
                return _rarity;
            }
            set
            {
                _rarity = value;
            } 
        }


        public GameItem(string name, Image image, Color color, RarityEnum.Rarity rarity, double minWear, double maxWear, string imageURL) : base(name, image, color)
        {
            _rarity = rarity;
            _minWear = minWear;
            _maxWear = maxWear;
            _wear = null;
            _imageURL = imageURL;
        }

        public GameItem(GameItem item) : base(item.Name, null, item.Color)
        {
            _wear = item.MinWear + ItemFactory.GetRandomNumber() * (item.MaxWear - item.MinWear);
            _rarity = item.Rarity;
            _imageURL = item.ImageURL;
        }

        public override string ToString()
        {
            return this.Name + " ; " + this.Wear;
        }
    }
}
