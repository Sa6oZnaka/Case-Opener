
namespace MyFirm.CaseOpener
{
    partial class FormMarket
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.item = new System.Windows.Forms.ColumnHeader();
            this.rarity = new System.Windows.Forms.ColumnHeader();
            this.wear = new System.Windows.Forms.ColumnHeader();
            this.seller = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.item,
            this.rarity,
            this.wear,
            this.seller,
            this.price});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(6, 44);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(788, 400);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.DisplayIndex = 5;
            this.id.Text = "id";
            this.id.Width = 50;
            // 
            // item
            // 
            this.item.DisplayIndex = 0;
            this.item.Text = "Item  Name";
            this.item.Width = 150;
            // 
            // rarity
            // 
            this.rarity.DisplayIndex = 4;
            this.rarity.Text = "Rarity";
            this.rarity.Width = 120;
            // 
            // wear
            // 
            this.wear.DisplayIndex = 1;
            this.wear.Text = "Wear";
            this.wear.Width = 120;
            // 
            // seller
            // 
            this.seller.DisplayIndex = 2;
            this.seller.Text = "Seller";
            // 
            // price
            // 
            this.price.DisplayIndex = 3;
            this.price.Text = "Price";
            // 
            // buttonBuy
            // 
            this.buttonBuy.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonBuy.Location = new System.Drawing.Point(705, 8);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 22);
            this.buttonBuy.TabIndex = 5;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxSearch.Location = new System.Drawing.Point(47, 8);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(167, 23);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBuy);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(8);
            this.panel1.Size = new System.Drawing.Size(788, 38);
            this.panel1.TabIndex = 7;
            // 
            // FormMarket
            // 
            this.AcceptButton = this.buttonBuy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMarket";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "Market";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMarket_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader wear;
        private System.Windows.Forms.ColumnHeader seller;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader rarity;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Panel panel1;
    }
}