﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MyFirm.CaseOpener.ClassLibraryUser
{
    [Serializable]
    public abstract class Item
    {

        private int _id;
        private String _name;
        private Image _image;
        private Color _colorFrame;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {

            }
        }

        public Color Color
        {
            get
            {
                return _colorFrame;
            }
            set
            {

            }
        }


        public int ID { 
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        protected Item(string name, Image image, Color color)
        {
            _name = name;
            _image = image;
            _colorFrame = color;
        }

        public abstract override string ToString();
    }
}
