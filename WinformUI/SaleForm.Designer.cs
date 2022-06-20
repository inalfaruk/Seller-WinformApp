namespace WinformUI
{
    partial class SaleForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkStockAdd = new System.Windows.Forms.CheckBox();
            this.btnStockAdd = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridSales = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.button27 = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelShortcuts = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.checkQuantity = new System.Windows.Forms.CheckBox();
            this.checkChange = new System.Windows.Forms.CheckBox();
            this.btnPartialPayment = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBarcode
            // 
            this.txtBarcode.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarcode.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBarcode.Font = new System.Drawing.Font("Carlito", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBarcode.Location = new System.Drawing.Point(0, 75);
            this.txtBarcode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.PlaceholderText = "Barkod... ";
            this.txtBarcode.Size = new System.Drawing.Size(531, 33);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            this.txtBarcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcode_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkStockAdd);
            this.panel1.Controls.Add(this.btnStockAdd);
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 656);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 34);
            this.panel1.TabIndex = 2;
            // 
            // checkStockAdd
            // 
            this.checkStockAdd.AutoSize = true;
            this.checkStockAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkStockAdd.Location = new System.Drawing.Point(1206, 0);
            this.checkStockAdd.Name = "checkStockAdd";
            this.checkStockAdd.Size = new System.Drawing.Size(105, 34);
            this.checkStockAdd.TabIndex = 36;
            this.checkStockAdd.Text = "Stok Giriş";
            this.checkStockAdd.UseVisualStyleBackColor = true;
            this.checkStockAdd.CheckedChanged += new System.EventHandler(this.checkAddStock_CheckedChanged);
            // 
            // btnStockAdd
            // 
            this.btnStockAdd.BackColor = System.Drawing.Color.DimGray;
            this.btnStockAdd.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStockAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockAdd.ForeColor = System.Drawing.Color.White;
            this.btnStockAdd.Location = new System.Drawing.Point(0, 0);
            this.btnStockAdd.Name = "btnStockAdd";
            this.btnStockAdd.Size = new System.Drawing.Size(147, 34);
            this.btnStockAdd.TabIndex = 2;
            this.btnStockAdd.Text = "Stok Giriş";
            this.btnStockAdd.UseVisualStyleBackColor = false;
            this.btnStockAdd.Visible = false;
            this.btnStockAdd.Click += new System.EventHandler(this.btnStockAdd_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTime.Location = new System.Drawing.Point(1311, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(59, 23);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "label4";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel2.Size = new System.Drawing.Size(531, 75);
            this.panel2.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTotal.Font = new System.Drawing.Font("Carlito", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(476, 20);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 36);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0 ₺";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridSales);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txtBarcode);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 656);
            this.panel3.TabIndex = 4;
            // 
            // gridSales
            // 
            this.gridSales.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Carlito", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSales.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridSales.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSales.Location = new System.Drawing.Point(0, 197);
            this.gridSales.Name = "gridSales";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Carlito", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridSales.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridSales.RowTemplate.Height = 25;
            this.gridSales.Size = new System.Drawing.Size(531, 459);
            this.gridSales.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDescription);
            this.panel4.Controls.Add(this.lblDiscount);
            this.panel4.Controls.Add(this.button27);
            this.panel4.Controls.Add(this.txtQuantity);
            this.panel4.Controls.Add(this.txtDiscount);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 108);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(531, 89);
            this.panel4.TabIndex = 12;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(0, 56);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Sipariş Açıklaması...";
            this.txtDescription.Size = new System.Drawing.Size(351, 31);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(392, 59);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(68, 23);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "İskonto";
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(69, 17);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 11;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(465, 9);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(59, 31);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.Text = "1";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(466, 55);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(58, 31);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar";
            // 
            // panelShortcuts
            // 
            this.panelShortcuts.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelShortcuts.Location = new System.Drawing.Point(982, 0);
            this.panelShortcuts.Name = "panelShortcuts";
            this.panelShortcuts.Size = new System.Drawing.Size(390, 656);
            this.panelShortcuts.TabIndex = 5;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button33);
            this.panel5.Controls.Add(this.button32);
            this.panel5.Controls.Add(this.button31);
            this.panel5.Controls.Add(this.button30);
            this.panel5.Controls.Add(this.button29);
            this.panel5.Controls.Add(this.button28);
            this.panel5.Controls.Add(this.checkQuantity);
            this.panel5.Controls.Add(this.checkChange);
            this.panel5.Controls.Add(this.btnPartialPayment);
            this.panel5.Controls.Add(this.btnPos);
            this.panel5.Controls.Add(this.btnCash);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.button10);
            this.panel5.Controls.Add(this.button9);
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.button7);
            this.panel5.Controls.Add(this.button6);
            this.panel5.Controls.Add(this.button5);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(531, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(451, 656);
            this.panel5.TabIndex = 6;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button33.ForeColor = System.Drawing.Color.White;
            this.button33.Location = new System.Drawing.Point(0, 245);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(122, 56);
            this.button33.TabIndex = 41;
            this.button33.Text = "100";
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button32.ForeColor = System.Drawing.Color.White;
            this.button32.Location = new System.Drawing.Point(0, 184);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(122, 56);
            this.button32.TabIndex = 40;
            this.button32.Text = "50";
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.Location = new System.Drawing.Point(0, 122);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(122, 56);
            this.button31.TabIndex = 39;
            this.button31.Text = "20";
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button30.ForeColor = System.Drawing.Color.White;
            this.button30.Location = new System.Drawing.Point(0, 61);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(122, 56);
            this.button30.TabIndex = 38;
            this.button30.Text = "10";
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button29.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button29.ForeColor = System.Drawing.Color.White;
            this.button29.Location = new System.Drawing.Point(0, 0);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(122, 56);
            this.button29.TabIndex = 37;
            this.button29.Text = "5";
            this.button29.UseVisualStyleBackColor = false;
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button28.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button28.ForeColor = System.Drawing.Color.White;
            this.button28.Location = new System.Drawing.Point(0, 306);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(122, 56);
            this.button28.TabIndex = 36;
            this.button28.Text = "200";
            this.button28.UseVisualStyleBackColor = false;
            // 
            // checkQuantity
            // 
            this.checkQuantity.AutoSize = true;
            this.checkQuantity.Location = new System.Drawing.Point(17, 590);
            this.checkQuantity.Name = "checkQuantity";
            this.checkQuantity.Size = new System.Drawing.Size(83, 27);
            this.checkQuantity.TabIndex = 35;
            this.checkQuantity.Text = "Miktar";
            this.checkQuantity.UseVisualStyleBackColor = true;
            // 
            // checkChange
            // 
            this.checkChange.AutoSize = true;
            this.checkChange.Location = new System.Drawing.Point(17, 623);
            this.checkChange.Name = "checkChange";
            this.checkChange.Size = new System.Drawing.Size(105, 27);
            this.checkChange.TabIndex = 34;
            this.checkChange.Text = "Para Üstü";
            this.checkChange.UseVisualStyleBackColor = true;
            // 
            // btnPartialPayment
            // 
            this.btnPartialPayment.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPartialPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartialPayment.ForeColor = System.Drawing.Color.White;
            this.btnPartialPayment.Location = new System.Drawing.Point(111, 482);
            this.btnPartialPayment.Name = "btnPartialPayment";
            this.btnPartialPayment.Size = new System.Drawing.Size(261, 74);
            this.btnPartialPayment.TabIndex = 33;
            this.btnPartialPayment.Text = "Kısmi Ödeme";
            this.btnPartialPayment.UseVisualStyleBackColor = false;
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.Coral;
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.ForeColor = System.Drawing.Color.White;
            this.btnPos.Location = new System.Drawing.Point(243, 389);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(129, 87);
            this.btnPos.TabIndex = 32;
            this.btnPos.Text = "POS";
            this.btnPos.UseVisualStyleBackColor = false;
            this.btnPos.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.Location = new System.Drawing.Point(111, 389);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(126, 87);
            this.btnCash.TabIndex = 31;
            this.btnCash.Text = "Nakit";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gray;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(346, 245);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(88, 67);
            this.button11.TabIndex = 30;
            this.button11.Text = ",";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gray;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(252, 245);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(88, 67);
            this.button10.TabIndex = 29;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(346, 172);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 67);
            this.button9.TabIndex = 28;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(252, 172);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 67);
            this.button8.TabIndex = 27;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(160, 172);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 67);
            this.button7.TabIndex = 26;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(346, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 67);
            this.button6.TabIndex = 25;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(252, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 67);
            this.button5.TabIndex = 24;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(160, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 67);
            this.button4.TabIndex = 23;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(346, 27);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 67);
            this.button3.TabIndex = 22;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(252, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 67);
            this.button2.TabIndex = 21;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(160, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 67);
            this.button1.TabIndex = 20;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 690);
            this.Controls.Add(this.panelShortcuts);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSales)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txtBarcode;
        private Panel panel1;
        private Panel panel2;
        private Label lblTotal;
        private Panel panel3;
        private DataGridView gridSales;
        private Label label3;
        private Panel panelShortcuts;
        private Label lblTime;
        private System.Windows.Forms.Timer timer;
        private Panel panel5;
        private Button btnPartialPayment;
        private Button btnPos;
        private Button btnCash;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label lblDiscount;
        private TextBox txtDiscount;
        private TextBox txtQuantity;
        private CheckBox checkChange;
        private TextBox txtDescription;
        private CheckBox checkQuantity;
        private Button button27;
        private CheckBox checkStockAdd;
        private Button btnStockAdd;
        private Button button33;
        private Button button32;
        private Button button31;
        private Button button30;
        private Button button29;
        private Button button28;
        private Panel panel4;
    }
}