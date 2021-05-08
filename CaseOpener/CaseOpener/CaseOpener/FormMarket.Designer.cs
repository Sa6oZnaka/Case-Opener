
namespace CaseOpener
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.item = new System.Windows.Forms.ColumnHeader();
            this.rarity = new System.Windows.Forms.ColumnHeader();
            this.wear = new System.Windows.Forms.ColumnHeader();
            this.seller = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(167, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
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
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 331);
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
            // 
            // wear
            // 
            this.wear.DisplayIndex = 1;
            this.wear.Text = "Wear";
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
            this.buttonBuy.Location = new System.Drawing.Point(280, 24);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 5;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // FormMarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormMarket";
            this.Text = "FormMarket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader item;
        private System.Windows.Forms.ColumnHeader wear;
        private System.Windows.Forms.ColumnHeader seller;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader rarity;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.ColumnHeader id;
    }
}