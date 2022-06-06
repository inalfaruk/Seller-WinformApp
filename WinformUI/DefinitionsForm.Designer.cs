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
            this.gridDefinitions = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSerch = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBrand = new System.Windows.Forms.Button();
            this.btnUnit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblDefinition = new System.Windows.Forms.Label();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDefinitions)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDefinitions
            // 
            this.gridDefinitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDefinitions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridDefinitions.Location = new System.Drawing.Point(0, 170);
            this.gridDefinitions.Name = "gridDefinitions";
            this.gridDefinitions.RowTemplate.Height = 25;
            this.gridDefinitions.Size = new System.Drawing.Size(278, 206);
            this.gridDefinitions.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSerch);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.lblDefinition);
            this.panel1.Controls.Add(this.txtDefinition);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 170);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnSerch
            // 
            this.btnSerch.Location = new System.Drawing.Point(227, 57);
            this.btnSerch.Name = "btnSerch";
            this.btnSerch.Size = new System.Drawing.Size(44, 26);
            this.btnSerch.TabIndex = 5;
            this.btnSerch.Text = "Ara";
            this.btnSerch.UseVisualStyleBackColor = true;
            this.btnSerch.Click += new System.EventHandler(this.btnSerch_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCategory);
            this.panel2.Controls.Add(this.btnBrand);
            this.panel2.Controls.Add(this.btnUnit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 29);
            this.panel2.TabIndex = 4;
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCategory.Location = new System.Drawing.Point(112, 0);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(59, 27);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "Kategori";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBrand
            // 
            this.btnBrand.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBrand.Location = new System.Drawing.Point(53, 0);
            this.btnBrand.Name = "btnBrand";
            this.btnBrand.Size = new System.Drawing.Size(59, 27);
            this.btnBrand.TabIndex = 4;
            this.btnBrand.Text = "Marka";
            this.btnBrand.UseVisualStyleBackColor = true;
            this.btnBrand.Click += new System.EventHandler(this.btnBrand_Click);
            // 
            // btnUnit
            // 
            this.btnUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUnit.Location = new System.Drawing.Point(0, 0);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.Size = new System.Drawing.Size(53, 27);
            this.btnUnit.TabIndex = 3;
            this.btnUnit.Text = "Birim";
            this.btnUnit.UseVisualStyleBackColor = true;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(112, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblDefinition
            // 
            this.lblDefinition.AutoSize = true;
            this.lblDefinition.Location = new System.Drawing.Point(3, 61);
            this.lblDefinition.Name = "lblDefinition";
            this.lblDefinition.Size = new System.Drawing.Size(35, 15);
            this.lblDefinition.TabIndex = 1;
            this.lblDefinition.Text = "Birim";
            // 
            // txtDefinition
            // 
            this.txtDefinition.Location = new System.Drawing.Point(58, 58);
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(168, 23);
            this.txtDefinition.TabIndex = 0;
            // 
            // DefinitionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridDefinitions);
            this.Name = "DefinitionsForm";
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
        private Button button1;
        private Button btnSerch;
    }
}