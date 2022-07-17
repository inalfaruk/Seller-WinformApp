namespace WinformUI
{
    partial class ShortcutForm
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
            this.btnAddShortcut = new System.Windows.Forms.Button();
            this.gridShortcutList = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtShortcutFilter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridProductList = new System.Windows.Forms.DataGridView();
            this.txtProductFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridShortcutList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddShortcut
            // 
            this.btnAddShortcut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddShortcut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShortcut.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddShortcut.ForeColor = System.Drawing.Color.White;
            this.btnAddShortcut.Location = new System.Drawing.Point(266, 125);
            this.btnAddShortcut.Name = "btnAddShortcut";
            this.btnAddShortcut.Size = new System.Drawing.Size(149, 34);
            this.btnAddShortcut.TabIndex = 1;
            this.btnAddShortcut.Text = "Kısayol Listesine Ekle ->";
            this.btnAddShortcut.UseVisualStyleBackColor = false;
            this.btnAddShortcut.Click += new System.EventHandler(this.btnAddShortcut_Click);
            // 
            // gridShortcutList
            // 
            this.gridShortcutList.BackgroundColor = System.Drawing.Color.White;
            this.gridShortcutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridShortcutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridShortcutList.Location = new System.Drawing.Point(2, 41);
            this.gridShortcutList.Margin = new System.Windows.Forms.Padding(2);
            this.gridShortcutList.Name = "gridShortcutList";
            this.gridShortcutList.RowHeadersVisible = false;
            this.gridShortcutList.RowTemplate.Height = 25;
            this.gridShortcutList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridShortcutList.Size = new System.Drawing.Size(258, 200);
            this.gridShortcutList.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(377, 38);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(46, 24);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtShortcutFilter
            // 
            this.txtShortcutFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtShortcutFilter.Location = new System.Drawing.Point(2, 18);
            this.txtShortcutFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtShortcutFilter.Name = "txtShortcutFilter";
            this.txtShortcutFilter.PlaceholderText = "Ara...";
            this.txtShortcutFilter.Size = new System.Drawing.Size(258, 23);
            this.txtShortcutFilter.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridShortcutList);
            this.groupBox1.Controls.Add(this.txtShortcutFilter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(420, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(262, 243);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kısayol Tanımları";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridProductList);
            this.groupBox2.Controls.Add(this.txtProductFilter);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(268, 243);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Listesi";
            // 
            // gridProductList
            // 
            this.gridProductList.BackgroundColor = System.Drawing.Color.White;
            this.gridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProductList.Location = new System.Drawing.Point(2, 41);
            this.gridProductList.Margin = new System.Windows.Forms.Padding(2);
            this.gridProductList.MultiSelect = false;
            this.gridProductList.Name = "gridProductList";
            this.gridProductList.RowHeadersVisible = false;
            this.gridProductList.RowTemplate.Height = 25;
            this.gridProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProductList.Size = new System.Drawing.Size(264, 200);
            this.gridProductList.TabIndex = 2;
            this.gridProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductList_CellContentClick);
            // 
            // txtProductFilter
            // 
            this.txtProductFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtProductFilter.Location = new System.Drawing.Point(2, 18);
            this.txtProductFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductFilter.Name = "txtProductFilter";
            this.txtProductFilter.PlaceholderText = "Ara...";
            this.txtProductFilter.Size = new System.Drawing.Size(264, 23);
            this.txtProductFilter.TabIndex = 5;
            // 
            // ShortcutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(682, 243);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddShortcut);
            this.Font = new System.Drawing.Font("Carlito", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShortcutForm";
            this.Load += new System.EventHandler(this.ShortcutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridShortcutList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddShortcut;
        private DataGridView gridShortcutList;
        private Button btnDelete;
        private TextBox txtShortcutFilter;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView gridProductList;
        private TextBox txtProductFilter;
    }
}