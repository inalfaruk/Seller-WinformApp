namespace WinformUI
{
    partial class DefinitionsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridDefinitions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnUnit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRenk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDefinitions)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDefinitions
            // 
            this.gridDefinitions.BackgroundColor = System.Drawing.Color.White;
            this.gridDefinitions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDefinitions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDefinitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDefinitions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridDefinitions.GridColor = System.Drawing.Color.Black;
            this.gridDefinitions.Location = new System.Drawing.Point(0, 197);
            this.gridDefinitions.Margin = new System.Windows.Forms.Padding(4);
            this.gridDefinitions.MultiSelect = false;
            this.gridDefinitions.Name = "gridDefinitions";
            this.gridDefinitions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridDefinitions.RowHeadersVisible = false;
            this.gridDefinitions.RowTemplate.Height = 25;
            this.gridDefinitions.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDefinitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDefinitions.Size = new System.Drawing.Size(329, 220);
            this.gridDefinitions.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnSerch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblDefinition);
            this.panel1.Controls.Add(this.txtDefinition);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 177);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(286, 147);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 29);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSerch
            // 
            this.btnSerch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSerch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerch.ForeColor = System.Drawing.Color.White;
            this.btnSerch.Location = new System.Drawing.Point(110, 89);
            this.btnSerch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(82, 33);
            this.btnSerch.TabIndex = 5;
            this.btnSerch.Text = "Ara";
            this.btnSerch.UseVisualStyleBackColor = false;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRenk);
            this.panel2.Controls.Add(this.btnCategory);
            this.panel2.Controls.Add(this.btnBrand);
            this.panel2.Controls.Add(this.btnUnit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(327, 36);
            this.panel2.TabIndex = 4;
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Location = new System.Drawing.Point(160, 0);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(85, 36);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Kategori";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrand.ForeColor = System.Drawing.Color.White;
            this.btnBrand.Location = new System.Drawing.Point(80, 0);
            this.btnBrand.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(80, 36);
            this.btnBrand.TabIndex = 4;
            this.btnBrand.Text = "Marka";
            this.btnBrand.UseVisualStyleBackColor = false;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnit.ForeColor = System.Drawing.Color.White;
            this.btnUnit.Location = new System.Drawing.Point(0, 0);
            this.btnUnit.Margin = new System.Windows.Forms.Padding(4);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(80, 36);
            this.btnUnit.TabIndex = 3;
            this.btnUnit.Text = "Birim";
            this.btnUnit.UseVisualStyleBackColor = false;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(200, 89);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 33);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Location = new System.Drawing.Point(12, 62);
            this.lblDefinition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(45, 19);
            this.lblDefinition.TabIndex = 1;
            this.lblDefinition.Text = "Birim";
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(110, 54);
            this.txtDefinition.Margin = new System.Windows.Forms.Padding(4);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(175, 27);
            this.txtDefinition.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::WinformUI.Properties.Resources.cross_1_;
            this.btnClose.Location = new System.Drawing.Point(301, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 20);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRenk
            // 
            this.btnRenk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRenk.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRenk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenk.ForeColor = System.Drawing.Color.White;
            this.btnRenk.Location = new System.Drawing.Point(245, 0);
            this.btnRenk.Margin = new System.Windows.Forms.Padding(4);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(85, 36);
            this.btnRenk.TabIndex = 6;
            this.btnRenk.Text = "Renk";
            this.btnRenk.UseVisualStyleBackColor = false;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // DefinitionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 417);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridDefinitions);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Carlito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DefinitionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tanımlar";
            this.Load += new System.EventHandler(this.DefinitionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDefinitions)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView gridDefinitions;
        private Panel panel1;
        private Panel panel2;
        private Button btnCategory;
        private Button btnBrand;
        private Button btnUnit;
        private Button btnAdd;
        private Label lblDefinition;
        private TextBox txtDefinition;
        private Button btnDelete;
        private Button btnSerch;
        private Button btnClose;
        private Button btnRenk;
    }
}