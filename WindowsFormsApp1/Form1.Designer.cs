namespace WindowsFormsApp1
{
    partial class MyForm
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
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.txtCatalog = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.chkbxAutoSave = new System.Windows.Forms.CheckBox();
            this.grpbxDataStore = new System.Windows.Forms.GroupBox();
            this.nmrAutoSave = new System.Windows.Forms.NumericUpDown();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.autoSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbxDataStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAutoSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(18, 34);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(71, 20);
            this.FilePathLabel.TabIndex = 0;
            this.FilePathLabel.Text = "File Path";
            // 
            // txtCatalog
            // 
            this.txtCatalog.Location = new System.Drawing.Point(95, 31);
            this.txtCatalog.Name = "txtCatalog";
            this.txtCatalog.Size = new System.Drawing.Size(280, 26);
            this.txtCatalog.TabIndex = 1;
            this.txtCatalog.Text = "Catalog.txt";
            this.txtCatalog.TextChanged += new System.EventHandler(this.txtCatalog_TextChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Gray;
            this.btnLoad.Location = new System.Drawing.Point(394, 28);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(109, 33);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // chkbxAutoSave
            // 
            this.chkbxAutoSave.AutoSize = true;
            this.chkbxAutoSave.Location = new System.Drawing.Point(93, 69);
            this.chkbxAutoSave.Name = "chkbxAutoSave";
            this.chkbxAutoSave.Size = new System.Drawing.Size(152, 24);
            this.chkbxAutoSave.TabIndex = 3;
            this.chkbxAutoSave.Text = "Auto Save Every";
            this.chkbxAutoSave.UseVisualStyleBackColor = true;
            this.chkbxAutoSave.CheckedChanged += new System.EventHandler(this.chkbxAutoSave_CheckedChanged);
            // 
            // grpbxDataStore
            // 
            this.grpbxDataStore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpbxDataStore.Controls.Add(this.nmrAutoSave);
            this.grpbxDataStore.Controls.Add(this.chkbxAutoSave);
            this.grpbxDataStore.Controls.Add(this.btnLoad);
            this.grpbxDataStore.Controls.Add(this.txtCatalog);
            this.grpbxDataStore.Controls.Add(this.FilePathLabel);
            this.grpbxDataStore.Location = new System.Drawing.Point(50, 25);
            this.grpbxDataStore.Name = "grpbxDataStore";
            this.grpbxDataStore.Size = new System.Drawing.Size(528, 117);
            this.grpbxDataStore.TabIndex = 4;
            this.grpbxDataStore.TabStop = false;
            this.grpbxDataStore.Text = "Data Store";
            // 
            // nmrAutoSave
            // 
            this.nmrAutoSave.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nmrAutoSave.Location = new System.Drawing.Point(270, 69);
            this.nmrAutoSave.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrAutoSave.Name = "nmrAutoSave";
            this.nmrAutoSave.Size = new System.Drawing.Size(120, 26);
            this.nmrAutoSave.TabIndex = 4;
            this.nmrAutoSave.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmrAutoSave.ValueChanged += new System.EventHandler(this.nmrAutoSave_ValueChanged);
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvProducts.Location = new System.Drawing.Point(50, 261);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 62;
            this.dgvProducts.RowTemplate.Height = 28;
            this.dgvProducts.Size = new System.Drawing.Size(680, 346);
            this.dgvProducts.TabIndex = 5;
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCreateProduct.Location = new System.Drawing.Point(50, 209);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(154, 38);
            this.btnCreateProduct.TabIndex = 6;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = false;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click_1);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(462, 221);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(44, 20);
            this.lblFilter.TabIndex = 7;
            this.lblFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.SystemColors.Control;
            this.txtFilter.Location = new System.Drawing.Point(523, 221);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(207, 26);
            this.txtFilter.TabIndex = 8;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Department";
            this.Column2.HeaderText = "Department";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Price";
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // MyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 695);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.grpbxDataStore);
            this.Name = "MyForm";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.MyForm_Load);
            this.grpbxDataStore.ResumeLayout(false);
            this.grpbxDataStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAutoSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.TextBox txtCatalog;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox chkbxAutoSave;
        private System.Windows.Forms.GroupBox grpbxDataStore;
        private System.Windows.Forms.NumericUpDown nmrAutoSave;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Timer autoSaveTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

