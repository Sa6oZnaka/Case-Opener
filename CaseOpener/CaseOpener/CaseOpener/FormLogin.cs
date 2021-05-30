using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyFirm.CaseOpener
{
    public partial class FormLogin : Form
    {
        private FormMenu form = new FormMenu();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Logout()
        {
            form = new FormMenu();
            this.Show();
        }

        private void ShowForm()
        {
            this.Hide();
            if (form.ShowDialog() == DialogResult.Abort)
            {
                Logout();
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (form.TryLogin(textBoxName.Text))
            {
                ShowForm();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (form.TryRegister(textBoxName.Text))
            {
                ShowForm();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
