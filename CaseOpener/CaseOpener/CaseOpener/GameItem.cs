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

        public RarityEnum.Rarity Rarity { 
            get {
                return _rarity;
            }
            set
            {
                _rarity = value;
            } 
        }


        public GameItem(string name, Image image, Color color, RarityEnum.Rarity rarity) : base(name, image, color)
        {
            _rarity = rarity;
            _wear = null;
        }

        public void generateWear()
        {
            if (_wear != null)
                return;

            Random random = new Random();
            _wear = random.Next(0, 1);
        }

    }
}
