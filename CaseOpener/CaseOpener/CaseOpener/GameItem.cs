using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CaseOpener 
{
    class GameItem : Item
    {

        private double? _wear;
        private double _minWear;
        private double _maxWear;

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
            set{}
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


        public GameItem(string name, Image image, Color color, RarityEnum.Rarity rarity, float minWear, float maxWear) : base(name, image, color)
        {
            _rarity = rarity;
            _minWear = minWear;
            _maxWear = maxWear;
            _wear = null;
        }

        public GameItem(GameItem item) : base(item.Name, null, item.Color)
        {
            _wear = item.MinWear + ItemFactory.GetRandomNumber() * item.MaxWear;
        }

        public override string ToString()
        {
            return this.Name + " ; " + this.Wear;
        }
    }
}
