
namespace MyFirm.CaseOpener
{
    partial class FormFriends
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.buttonPending = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 15;
            this.listBoxFriends.Location = new System.Drawing.Point(6, 36);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(788, 408);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.DoubleClick += new System.EventHandler(this.listBoxFriends_DoubleClick);
            // 
            // buttonPending
            // 
            this.buttonPending.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPending.Location = new System.Drawing.Point(79, 4);
            this.buttonPending.Name = "buttonPending";
            this.buttonPending.Size = new System.Drawing.Size(75, 22);
            this.buttonPending.TabIndex = 1;
            this.buttonPending.Text = "Pending";
            this.buttonPending.UseVisualStyleBackColor = true;
            this.buttonPending.Click += new System.EventHandler(this.buttonPending_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonFriends.Location = new System.Drawing.Point(4, 4);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(75, 22);
            this.buttonFriends.TabIndex = 2;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = true;
            this.buttonFriends.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxUser.Location = new System.Drawing.Point(519, 4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(190, 23);
            this.textBoxUser.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAdd.Location = new System.Drawing.Point(709, 4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 22);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxUser);
            this.panel1.Controls.Add(this.buttonPending);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.buttonFriends);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(788, 30);
            this.panel1.TabIndex = 5;
            // 
            // FormFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.panel1);
            this.Name = "FormFriends";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "Friends";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.Button buttonPending;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel1;
    }
}