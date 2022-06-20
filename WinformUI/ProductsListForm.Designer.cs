namespace WinformUI
{
    partial class ProductsListForm
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
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioCategory = new System.Windows.Forms.RadioButton();
            this.radioBrand = new System.Windows.Forms.RadioButton();
            this.radioStokName = new System.Windows.Forms.RadioButton();
            this.radioStockCode = new System.Windows.Forms.RadioButton();
            this.radioBarcode = new System.Windows.Forms.RadioButton();
            this.gridProductList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtFilter);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 749);
            this.panel1.TabIndex = 0;
            // 
            // txtFilter
            // 
            this.txtFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtFilter.Location = new System.Drawing.Point(0, 141);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(5);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.PlaceholderText = "Aramak için buraya yazın.";
            this.txtFilter.Size = new System.Drawing.Size(228, 33);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.radioCategory);
            this.panel2.Controls.Add(this.radioBrand);
            this.panel2.Controls.Add(this.radioStokName);
            this.panel2.Controls.Add(this.radioStockCode);
            this.panel2.Controls.Add(this.radioBarcode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 141);
            this.panel2.TabIndex = 2;
            // 
            // radioCategory
            // 
            this.radioCategory.AutoSize = true;
            this.radioCategory.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioCategory.ForeColor = System.Drawing.Color.White;
            this.radioCategory.Location = new System.Drawing.Point(13, 106);
            this.radioCategory.Margin = new System.Windows.Forms.Padding(5);
            this.radioCategory.Name = "radioCategory";
            this.radioCategory.Size = new System.Drawing.Size(92, 27);
            this.radioCategory.TabIndex = 7;
            this.radioCategory.TabStop = true;
            this.radioCategory.Text = "Kategori";
            this.radioCategory.UseVisualStyleBackColor = true;
            // 
            // radioBrand
            // 
            this.radioBrand.AutoSize = true;
            this.radioBrand.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBrand.ForeColor = System.Drawing.Color.White;
            this.radioBrand.Location = new System.Drawing.Point(14, 81);
            this.radioBrand.Margin = new System.Windows.Forms.Padding(5);
            this.radioBrand.Name = "radioBrand";
            this.radioBrand.Size = new System.Drawing.Size(78, 27);
            this.radioBrand.TabIndex = 6;
            this.radioBrand.TabStop = true;
            this.radioBrand.Text = "Marka";
            this.radioBrand.UseVisualStyleBackColor = true;
            // 
            // radioStokName
            // 
            this.radioStokName.AutoSize = true;
            this.radioStokName.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioStokName.ForeColor = System.Drawing.Color.White;
            this.radioStokName.Location = new System.Drawing.Point(14, 33);
            this.radioStokName.Margin = new System.Windows.Forms.Padding(5);
            this.radioStokName.Name = "radioStokName";
            this.radioStokName.Size = new System.Drawing.Size(91, 27);
            this.radioStokName.TabIndex = 5;
            this.radioStokName.TabStop = true;
            this.radioStokName.Text = "Stok Adı";
            this.radioStokName.UseVisualStyleBackColor = true;
            // 
            // radioStockCode
            // 
            this.radioStockCode.AutoSize = true;
            this.radioStockCode.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioStockCode.ForeColor = System.Drawing.Color.White;
            this.radioStockCode.Location = new System.Drawing.Point(14, 8);
            this.radioStockCode.Margin = new System.Windows.Forms.Padding(5);
            this.radioStockCode.Name = "radioStockCode";
            this.radioStockCode.Size = new System.Drawing.Size(106, 27);
            this.radioStockCode.TabIndex = 4;
            this.radioStockCode.TabStop = true;
            this.radioStockCode.Text = "Stok Kodu";
            this.radioStockCode.UseVisualStyleBackColor = true;
            // 
            // radioBarcode
            // 
            this.radioBarcode.AutoSize = true;
            this.radioBarcode.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioBarcode.ForeColor = System.Drawing.Color.White;
            this.radioBarcode.Location = new System.Drawing.Point(14, 57);
            this.radioBarcode.Margin = new System.Windows.Forms.Padding(5);
            this.radioBarcode.Name = "radioBarcode";
            this.radioBarcode.Size = new System.Drawing.Size(82, 27);
            this.radioBarcode.TabIndex = 3;
            this.radioBarcode.TabStop = true;
            this.radioBarcode.Text = "Barkod";
            this.radioBarcode.UseVisualStyleBackColor = true;
            // 
            // gridProductList
            // 
            this.gridProductList.BackgroundColor = System.Drawing.Color.White;
            this.gridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductList.Location = new System.Drawing.Point(228, 0);
            this.gridProductList.Margin = new System.Windows.Forms.Padding(5);
            this.gridProductList.Name = "gridProductList";
            this.gridProductList.RowHeadersVisible = false;
            this.gridProductList.RowTemplate.Height = 25;
            this.gridProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductList.Size = new System.Drawing.Size(1142, 749);
            this.gridProductList.TabIndex = 1;
            // 
            // ProductsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.gridProductList);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ProductsListForm";
            this.Text = "ProductsListForm";
            this.Load += new System.EventHandler(this.ProductsListForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox txtFilter;
        private DataGridView gridProductList;
        private Panel panel2;
        private RadioButton radioBrand;
        private RadioButton radioStokName;
        private RadioButton radioStockCode;
        private RadioButton radioBarcode;
        private RadioButton radioCategory;
    }
}