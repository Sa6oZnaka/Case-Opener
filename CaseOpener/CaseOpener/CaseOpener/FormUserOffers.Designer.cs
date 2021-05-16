
namespace CaseOpener
{
    partial class FormUserOffers
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
            this.listBoxOffers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxOffers
            // 
            this.listBoxOffers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOffers.FormattingEnabled = true;
            this.listBoxOffers.ItemHeight = 15;
            this.listBoxOffers.Location = new System.Drawing.Point(7, 7);
            this.listBoxOffers.Name = "listBoxOffers";
            this.listBoxOffers.Size = new System.Drawing.Size(786, 436);
            this.listBoxOffers.TabIndex = 0;
            this.listBoxOffers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOffers_MouseDoubleClick);
            // 
            // FormUserOffers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxOffers);
            this.Name = "FormUserOffers";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Text = "Offers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUserOffers_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxOffers;
    }
}