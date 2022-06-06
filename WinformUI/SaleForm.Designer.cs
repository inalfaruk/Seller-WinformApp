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
            this.lblTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button27 = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.gridSales = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 656);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 34);
            this.panel1.TabIndex = 2;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblTime.Location = new System.Drawing.Point(1188, 0);
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
            this.panel3.Controls.Add(this.button27);
            this.panel3.Controls.Add(this.txtDescription);
            this.panel3.Controls.Add(this.lblDiscount);
            this.panel3.Controls.Add(this.txtQuantity);
            this.panel3.Controls.Add(this.txtDiscount);
            this.panel3.Controls.Add(this.gridSales);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBarcode);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(531, 656);
            this.panel3.TabIndex = 4;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(308, 121);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 23);
            this.button27.TabIndex = 11;
            this.button27.Text = "button27";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(3, 166);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Sipariş Açıklaması...";
            this.txtDescription.Size = new System.Drawing.Size(351, 31);
            this.txtDescription.TabIndex = 10;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(382, 171);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(68, 23);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "İskonto";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(455, 121);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(59, 31);
            this.txtQuantity.TabIndex = 7;
            this.txtQuantity.Text = "1";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(456, 167);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(58, 31);
            this.txtDiscount.TabIndex = 8;
            this.txtDiscount.Text = "0";
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
            this.gridSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridSales.Location = new System.Drawing.Point(0, 203);
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
            this.gridSales.Size = new System.Drawing.Size(531, 453);
            this.gridSales.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Miktar";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button24);
            this.panel4.Controls.Add(this.button25);
            this.panel4.Controls.Add(this.button26);
            this.panel4.Controls.Add(this.button21);
            this.panel4.Controls.Add(this.button22);
            this.panel4.Controls.Add(this.button23);
            this.panel4.Controls.Add(this.button18);
            this.panel4.Controls.Add(this.button19);
            this.panel4.Controls.Add(this.button20);
            this.panel4.Controls.Add(this.button17);
            this.panel4.Controls.Add(this.button16);
            this.panel4.Controls.Add(this.button15);
            this.panel4.Controls.Add(this.button14);
            this.panel4.Controls.Add(this.button13);
            this.panel4.Controls.Add(this.button12);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(844, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(403, 656);
            this.panel4.TabIndex = 5;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(278, 482);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(109, 99);
            this.button24.TabIndex = 14;
            this.button24.Text = "button24";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(152, 482);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(109, 99);
            this.button25.TabIndex = 13;
            this.button25.Text = "button25";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(26, 484);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(109, 99);
            this.button26.TabIndex = 12;
            this.button26.Text = "button26";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(278, 365);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(109, 99);
            this.button21.TabIndex = 11;
            this.button21.Text = "button21";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(152, 365);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(109, 99);
            this.button22.TabIndex = 10;
            this.button22.Text = "button22";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(26, 367);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(109, 99);
            this.button23.TabIndex = 9;
            this.button23.Text = "button23";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(278, 245);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(109, 99);
            this.button18.TabIndex = 8;
            this.button18.Text = "button18";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(152, 245);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(109, 99);
            this.button19.TabIndex = 7;
            this.button19.Text = "button19";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(26, 248);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(109, 99);
            this.button20.TabIndex = 6;
            this.button20.Text = "button20";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(278, 129);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(109, 99);
            this.button17.TabIndex = 5;
            this.button17.Text = "button17";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(152, 129);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(109, 99);
            this.button16.TabIndex = 4;
            this.button16.Text = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(26, 133);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(109, 99);
            this.button15.TabIndex = 3;
            this.button15.Text = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(278, 12);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(109, 99);
            this.button14.TabIndex = 2;
            this.button14.Text = "button14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(152, 12);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(109, 99);
            this.button13.TabIndex = 1;
            this.button13.Text = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(26, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(109, 99);
            this.button12.TabIndex = 0;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel5
            // 
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
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(531, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(313, 656);
            this.panel5.TabIndex = 6;
            // 
            // checkQuantity
            // 
            this.checkQuantity.AutoSize = true;
            this.checkQuantity.Location = new System.Drawing.Point(128, 623);
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
            this.btnPartialPayment.Location = new System.Drawing.Point(47, 379);
            this.btnPartialPayment.Name = "btnPartialPayment";
            this.btnPartialPayment.Size = new System.Drawing.Size(237, 74);
            this.btnPartialPayment.TabIndex = 33;
            this.btnPartialPayment.Text = "Kısmi Ödeme";
            this.btnPartialPayment.UseVisualStyleBackColor = false;
            // 
            // btnPos
            // 
            this.btnPos.BackColor = System.Drawing.Color.Coral;
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.ForeColor = System.Drawing.Color.White;
            this.btnPos.Location = new System.Drawing.Point(170, 278);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(117, 87);
            this.btnPos.TabIndex = 32;
            this.btnPos.Text = "POS";
            this.btnPos.UseVisualStyleBackColor = false;
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.LimeGreen;
            this.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCash.ForeColor = System.Drawing.Color.White;
            this.btnCash.Location = new System.Drawing.Point(44, 278);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(114, 87);
            this.btnCash.TabIndex = 31;
            this.btnCash.Text = "Nakit";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button11.Location = new System.Drawing.Point(209, 203);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(76, 56);
            this.button11.TabIndex = 30;
            this.button11.Text = ",";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button10.Location = new System.Drawing.Point(128, 203);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(76, 56);
            this.button10.TabIndex = 29;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(209, 141);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 56);
            this.button9.TabIndex = 28;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(128, 141);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 56);
            this.button8.TabIndex = 27;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(47, 141);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(76, 56);
            this.button7.TabIndex = 26;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(209, 79);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(76, 56);
            this.button6.TabIndex = 25;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(128, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 56);
            this.button5.TabIndex = 24;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(47, 79);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 56);
            this.button4.TabIndex = 23;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(209, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 56);
            this.button3.TabIndex = 22;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(128, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 56);
            this.button2.TabIndex = 21;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Carlito", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(47, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1247, 690);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Carlito", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
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
        private Panel panel4;
        private Label lblTime;
        private System.Windows.Forms.Timer timer;
        private Button button24;
        private Button button25;
        private Button button26;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button13;
        private Button button12;
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
    }
}