using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CaseOpener
{
    class Case : Item
    {

        List<GameItem> _items;

        public Case(string name, Image image, Color color, List<GameItem> items) : base(name, image, color)
        {
            _items = items;
        }

        void open()
        {


        }

    }
}
