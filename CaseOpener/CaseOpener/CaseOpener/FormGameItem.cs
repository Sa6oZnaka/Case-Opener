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
        public FormGameItem(string name, double wear)
        {
            InitializeComponent();


            this.labelName.Text += name;
            this.labelWear.Text += wear;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
