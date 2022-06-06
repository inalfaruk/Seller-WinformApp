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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnDefinitions = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(433, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnProducts
            // 
            this.btnProducts.Location = new System.Drawing.Point(21, 22);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(89, 53);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Stok Listesi";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDefinitions
            // 
            this.btnDefinitions.Location = new System.Drawing.Point(21, 93);
            this.btnDefinitions.Name = "btnDefinitions";
            this.btnDefinitions.Size = new System.Drawing.Size(89, 53);
            this.btnDefinitions.TabIndex = 2;
            this.btnDefinitions.Text = "Tanımlar";
            this.btnDefinitions.UseVisualStyleBackColor = true;
            this.btnDefinitions.Click += new System.EventHandler(this.btnDefinitions_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Satış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(141, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stok Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDefinitions);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnProducts;
        private Button btnDefinitions;
        private Button button1;
        private Button button2;
    }
}