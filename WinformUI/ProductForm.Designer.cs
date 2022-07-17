namespace WinformUI
{
    partial class ProductForm
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
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureProduct = new System.Windows.Forms.PictureBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtCriticalQantity = new System.Windows.Forms.TextBox();
            this.txtSpecialCode2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSpecialCode = new System.Windows.Forms.TextBox();
            this.txtSalePrice = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbBrand = new System.Windows.Forms.ComboBox();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtStockCode = new System.Windows.Forms.TextBox();
            this.lblEditMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.BackgroundColor = System.Drawing.Color.White;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridProducts.Location = new System.Drawing.Point(0, 350);
            this.gridProducts.MultiSelect = false;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.ReadOnly = true;
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.RowTemplate.Height = 25;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.Size = new System.Drawing.Size(772, 170);
            this.gridProducts.TabIndex = 36;
            this.gridProducts.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridProducts_CellMouseDoubleClick);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(563, 275);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(151, 25);
            this.txtQuantity.TabIndex = 124;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(515, 278);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 17);
            this.label16.TabIndex = 123;
            this.label16.Text = "Stok";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(230, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(29, 26);
            this.button4.TabIndex = 122;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(230, 207);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(29, 26);
            this.button5.TabIndex = 121;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(230, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(29, 26);
            this.button3.TabIndex = 120;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(230, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 26);
            this.button2.TabIndex = 119;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImage.ForeColor = System.Drawing.Color.White;
            this.btnSelectImage.Location = new System.Drawing.Point(669, 23);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(87, 26);
            this.btnSelectImage.TabIndex = 118;
            this.btnSelectImage.Text = "Resim Seç...";
            this.btnSelectImage.UseVisualStyleBackColor = false;
            // 
            // txtVat
            // 
            this.txtVat.Location = new System.Drawing.Point(335, 207);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(151, 25);
            this.txtVat.TabIndex = 117;
            this.txtVat.Text = "18";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(267, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 35);
            this.btnCancel.TabIndex = 116;
            this.btnCancel.Text = "Vazgeç";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(532, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 17);
            this.label15.TabIndex = 115;
            this.label15.Text = "Açıklama";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(532, 186);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(224, 83);
            this.txtDescription.TabIndex = 114;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(379, 298);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 35);
            this.btnSave.TabIndex = 113;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureProduct
            // 
            this.pictureProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureProduct.Location = new System.Drawing.Point(532, 21);
            this.pictureProduct.Name = "pictureProduct";
            this.pictureProduct.Size = new System.Drawing.Size(130, 133);
            this.pictureProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureProduct.TabIndex = 112;
            this.pictureProduct.TabStop = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(336, 244);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(151, 25);
            this.txtDiscount.TabIndex = 111;
            this.txtDiscount.Text = "0";
            // 
            // txtCriticalQantity
            // 
            this.txtCriticalQantity.Location = new System.Drawing.Point(335, 171);
            this.txtCriticalQantity.Name = "txtCriticalQantity";
            this.txtCriticalQantity.Size = new System.Drawing.Size(151, 25);
            this.txtCriticalQantity.TabIndex = 110;
            // 
            // txtSpecialCode2
            // 
            this.txtSpecialCode2.Location = new System.Drawing.Point(336, 134);
            this.txtSpecialCode2.Name = "txtSpecialCode2";
            this.txtSpecialCode2.Size = new System.Drawing.Size(151, 25);
            this.txtSpecialCode2.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 108;
            this.label5.Text = "İndirim";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 107;
            this.label9.Text = "Kdv";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 106;
            this.label10.Text = "Kritik Stok";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(267, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 17);
            this.label11.TabIndex = 105;
            this.label11.Text = "Özel Kod 2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 104;
            this.label12.Text = "Özel Kod";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(267, 66);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 103;
            this.label13.Text = "Satış Fiyatı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(267, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 102;
            this.label14.Text = "Alış Fiyatı";
            // 
            // txtSpecialCode
            // 
            this.txtSpecialCode.Location = new System.Drawing.Point(336, 98);
            this.txtSpecialCode.Name = "txtSpecialCode";
            this.txtSpecialCode.Size = new System.Drawing.Size(151, 25);
            this.txtSpecialCode.TabIndex = 101;
            // 
            // txtSalePrice
            // 
            this.txtSalePrice.Location = new System.Drawing.Point(336, 61);
            this.txtSalePrice.Name = "txtSalePrice";
            this.txtSalePrice.Size = new System.Drawing.Size(151, 25);
            this.txtSalePrice.TabIndex = 100;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(336, 26);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(151, 25);
            this.txtPurchasePrice.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 98;
            this.label6.Text = "Renk";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 97;
            this.label7.Text = "Marka";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 96;
            this.label8.Text = "Birim";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 95;
            this.label4.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 94;
            this.label3.Text = "Ürün Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 93;
            this.label2.Text = "Barkod";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 92;
            this.label1.Text = "Stok Kodu";
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(78, 244);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(151, 25);
            this.cmbColor.TabIndex = 91;
            // 
            // cmbBrand
            // 
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(78, 207);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.Size = new System.Drawing.Size(151, 25);
            this.cmbBrand.TabIndex = 90;
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(78, 171);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(151, 25);
            this.cmbUnit.TabIndex = 89;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(78, 135);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(151, 25);
            this.cmbCategory.TabIndex = 88;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(78, 98);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(151, 25);
            this.txtProductName.TabIndex = 87;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(78, 61);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(151, 25);
            this.txtBarcode.TabIndex = 86;
            // 
            // txtStockCode
            // 
            this.txtStockCode.Location = new System.Drawing.Point(78, 26);
            this.txtStockCode.Name = "txtStockCode";
            this.txtStockCode.Size = new System.Drawing.Size(151, 25);
            this.txtStockCode.TabIndex = 85;
            // 
            // lblEditMode
            // 
            this.lblEditMode.AutoSize = true;
            this.lblEditMode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEditMode.ForeColor = System.Drawing.Color.Red;
            this.lblEditMode.Location = new System.Drawing.Point(0, 326);
            this.lblEditMode.Name = "lblEditMode";
            this.lblEditMode.Size = new System.Drawing.Size(98, 21);
            this.lblEditMode.TabIndex = 125;
            this.lblEditMode.Text = "Edit Mode...";
            this.lblEditMode.Visible = false;
            this.lblEditMode.Click += new System.EventHandler(this.lblEditMode_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 520);
            this.Controls.Add(this.lblEditMode);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureProduct);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtCriticalQantity);
            this.Controls.Add(this.txtSpecialCode2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtSpecialCode);
            this.Controls.Add(this.txtSalePrice);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.cmbBrand);
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.txtStockCode);
            this.Controls.Add(this.gridProducts);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView gridProducts;
        private TextBox txtQuantity;
        private Label label16;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button btnSelectImage;
        private TextBox txtVat;
        private Button btnCancel;
        private Label label15;
        private TextBox txtDescription;
        private Button btnSave;
        private PictureBox pictureProduct;
        private TextBox txtDiscount;
        private TextBox txtCriticalQantity;
        private TextBox txtSpecialCode2;
        private Label label5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox txtSpecialCode;
        private TextBox txtSalePrice;
        private TextBox txtPurchasePrice;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbColor;
        private ComboBox cmbBrand;
        private ComboBox cmbUnit;
        private ComboBox cmbCategory;
        private TextBox txtProductName;
        private TextBox txtBarcode;
        private TextBox txtStockCode;
        private Label lblEditMode;
    }
}