using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CaseOpener 
{
    class GameItem : Item
    {

        private float? _wear;
        RarityEnum.Rarity _rarity;

        public float? Wear {
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

        override
        public float generateWear(float minWear, float maxWear)
        {
            Random random = new Random();
            return minWear + (float)random.Next(0, 1000000000) / 1000000000 * maxWear;
        }

    }
}
