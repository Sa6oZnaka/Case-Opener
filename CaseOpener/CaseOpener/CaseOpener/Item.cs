using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CaseOpener
{
    abstract class Item
    {
        private String _name;
        private Image _image;
        private Color _colorFrame;

        protected Item(string name, Image image, Color color)
        {
            _name = name;
            _image = image;
            _colorFrame = color;

        }
    }
}
