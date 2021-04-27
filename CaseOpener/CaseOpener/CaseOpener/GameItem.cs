using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CaseOpener 
{
    class GameItem : Item
    {

        private double? _wear;
        RarityEnum.Rarity _rarity;

        public double? Wear {
            get
            {
                return _wear;
            }
            set
            {
              
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


        public GameItem(string name, Image image, Color color, RarityEnum.Rarity rarity, float minWear, float maxWear) : base(name, image, color)
        {
            _rarity = rarity;
            _wear = generateWear(minWear, maxWear);
        }

        public double generateWear(double minWear, double maxWear)
        {
            Random random = new Random();
            return minWear + random.NextDouble() * maxWear;
        }

        public override string ToString()
        {
            return this.Name + " ; " + this.Wear;
        }
    }
}
