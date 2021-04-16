using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CaseOpener 
{
    class GameItem : Item
    {

        private float? _wear;
        int _rarity; 

        public GameItem(string name, Image image, Color color, int rarity) : base(name, image, color)
        {
            _rarity = rarity;
            _wear = null;
        }

        private void generateWear()
        {
            if (_wear != null)
                return;

            Random random = new Random();
            _wear = random.Next(0, 1);
        }

    }
}
