using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CaseOpener
{
    public partial class FormLogin : Form
    {

        public string Name 
        {
            get
            {
                return textBoxName.Text;
            }
            set
            {

            }
        }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
