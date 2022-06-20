namespace WinformUI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnDefinitions = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShortcut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Image = global::WinformUI.Properties.Resources.quality;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(343, 183);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(6);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(213, 131);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Stok Listesi";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDefinitions
            // 
            this.btnDefinitions.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDefinitions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefinitions.ForeColor = System.Drawing.Color.White;
            this.btnDefinitions.Image = global::WinformUI.Properties.Resources.note;
            this.btnDefinitions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDefinitions.Location = new System.Drawing.Point(343, 44);
            this.btnDefinitions.Margin = new System.Windows.Forms.Padding(6);
            this.btnDefinitions.Name = "btnDefinitions";
            this.btnDefinitions.Size = new System.Drawing.Size(213, 131);
            this.btnDefinitions.TabIndex = 2;
            this.btnDefinitions.Text = "Tanımlar";
            this.btnDefinitions.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDefinitions.UseVisualStyleBackColor = false;
            this.btnDefinitions.Click += new System.EventHandler(this.btnDefinitions_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WinformUI.Properties.Resources.shopping;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(45, 44);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(286, 252);
            this.button1.TabIndex = 3;
            this.button1.Text = "Satış Ekranı";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::WinformUI.Properties.Resources.add;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(45, 307);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(286, 147);
            this.button2.TabIndex = 4;
            this.button2.Text = "        Stok Ekle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::WinformUI.Properties.Resources.cross_1_;
            this.btnClose.Location = new System.Drawing.Point(566, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShortcut
            // 
            this.btnShortcut.BackColor = System.Drawing.Color.Plum;
            this.btnShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShortcut.ForeColor = System.Drawing.Color.White;
            this.btnShortcut.Image = global::WinformUI.Properties.Resources.shortcuticon;
            this.btnShortcut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShortcut.Location = new System.Drawing.Point(343, 323);
            this.btnShortcut.Margin = new System.Windows.Forms.Padding(6);
            this.btnShortcut.Name = "btnShortcut";
            this.btnShortcut.Size = new System.Drawing.Size(213, 131);
            this.btnShortcut.TabIndex = 7;
            this.btnShortcut.Text = "Satış Kısayoları";
            this.btnShortcut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShortcut.UseVisualStyleBackColor = false;
            this.btnShortcut.Click += new System.EventHandler(this.btnShortcut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 490);
            this.Controls.Add(this.btnShortcut);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDefinitions);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnProducts);
            this.Font = new System.Drawing.Font("Carlito", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnProducts;
        private Button btnDefinitions;
        private Button button1;
        private Button button2;
        private Button btnClose;
        private Button btnShortcut;
    }
}