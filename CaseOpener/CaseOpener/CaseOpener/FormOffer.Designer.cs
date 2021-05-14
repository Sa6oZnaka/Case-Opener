
namespace CaseOpener
{
    partial class FormOffer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemoveFriend = new System.Windows.Forms.Button();
            this.buttonSendOffer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listBoxReceave = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBoxSend = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRemoveFriend);
            this.panel1.Controls.Add(this.buttonSendOffer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(800, 49);
            this.panel1.TabIndex = 0;
            // 
            // buttonRemoveFriend
            // 
            this.buttonRemoveFriend.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonRemoveFriend.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRemoveFriend.Location = new System.Drawing.Point(646, 4);
            this.buttonRemoveFriend.Name = "buttonRemoveFriend";
            this.buttonRemoveFriend.Size = new System.Drawing.Size(75, 41);
            this.buttonRemoveFriend.TabIndex = 1;
            this.buttonRemoveFriend.Text = "Remove Friend";
            this.buttonRemoveFriend.UseVisualStyleBackColor = true;
            // 
            // buttonSendOffer
            // 
            this.buttonSendOffer.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonSendOffer.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSendOffer.Location = new System.Drawing.Point(721, 4);
            this.buttonSendOffer.Name = "buttonSendOffer";
            this.buttonSendOffer.Size = new System.Drawing.Size(75, 41);
            this.buttonSendOffer.TabIndex = 0;
            this.buttonSendOffer.Text = "Send Offer";
            this.buttonSendOffer.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listBoxReceave);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(412, 49);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(388, 401);
            this.panel2.TabIndex = 1;
            // 
            // listBoxReceave
            // 
            this.listBoxReceave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxReceave.FormattingEnabled = true;
            this.listBoxReceave.ItemHeight = 15;
            this.listBoxReceave.Location = new System.Drawing.Point(5, 20);
            this.listBoxReceave.Name = "listBoxReceave";
            this.listBoxReceave.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxReceave.Size = new System.Drawing.Size(378, 376);
            this.listBoxReceave.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Receave items: (Friend\'s items)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBoxSend);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 49);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(406, 401);
            this.panel3.TabIndex = 2;
            // 
            // listBoxSend
            // 
            this.listBoxSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSend.FormattingEnabled = true;
            this.listBoxSend.ItemHeight = 15;
            this.listBoxSend.Location = new System.Drawing.Point(5, 20);
            this.listBoxSend.Name = "listBoxSend";
            this.listBoxSend.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSend.Size = new System.Drawing.Size(396, 376);
            this.listBoxSend.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Send items (My inventory)";
            // 
            // FormOffer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormOffer";
            this.Text = "FormOffer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRemoveFriend;
        private System.Windows.Forms.Button buttonSendOffer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBoxReceave;
        private System.Windows.Forms.ListBox listBoxSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}