using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaseOpener
{
    public partial class FormGameItem : Form
    {

        private GameItem _item;

        public string TextBoxPrice { 
            get
            {
                return textBoxPrice.Text;
            }
            set { } 
        }

        public FormGameItem(Item item)
        {
            InitializeComponent();

            _item = (GameItem)item;

            labelName.Text += _item.Name;
            labelWear.Text += _item.Wear;
            labelQuality.Text += _item.Rarity;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSell_Click(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int padding = 10,
                size = 200;

            Image newImage = Image.FromFile(_item.ImageURL);
            e.Graphics.DrawImage(newImage, padding, padding, size, size);

            drawFrame(e, padding, size + padding);
        }

        private void drawFrame(PaintEventArgs e, int padding, int size)
        {
            var color = _item.Color;
            var pen = new Pen(color);
            e.Graphics.DrawLine(pen, padding, padding, padding, size);
            e.Graphics.DrawLine(pen, padding, padding, size, padding);

            e.Graphics.DrawLine(pen, size, padding, size, size);
            e.Graphics.DrawLine(pen, padding, size, size, size);
        }


    }
}
