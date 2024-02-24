namespace WindowsFormsApp1
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
            this.productGroupBox = new System.Windows.Forms.GroupBox();
            this.nmrProductPrice = new System.Windows.Forms.NumericUpDown();
            this.cmbxProductCategory = new System.Windows.Forms.ComboBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnProductCreate = new System.Windows.Forms.Button();
            this.btnProductCancel = new System.Windows.Forms.Button();
            this.productGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProductPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // productGroupBox
            // 
            this.productGroupBox.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.productGroupBox.Controls.Add(this.nmrProductPrice);
            this.productGroupBox.Controls.Add(this.cmbxProductCategory);
            this.productGroupBox.Controls.Add(this.txtProductName);
            this.productGroupBox.Controls.Add(this.lblPrice);
            this.productGroupBox.Controls.Add(this.lblCategory);
            this.productGroupBox.Controls.Add(this.lblName);
            this.productGroupBox.Location = new System.Drawing.Point(51, 42);
            this.productGroupBox.Name = "productGroupBox";
            this.productGroupBox.Size = new System.Drawing.Size(425, 210);
            this.productGroupBox.TabIndex = 1;
            this.productGroupBox.TabStop = false;
            this.productGroupBox.Text = "Product";
            // 
            // nmrProductPrice
            // 
            this.nmrProductPrice.DecimalPlaces = 2;
            this.nmrProductPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nmrProductPrice.Location = new System.Drawing.Point(107, 152);
            this.nmrProductPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrProductPrice.Name = "nmrProductPrice";
            this.nmrProductPrice.Size = new System.Drawing.Size(152, 26);
            this.nmrProductPrice.TabIndex = 5;
            this.nmrProductPrice.Value = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            // 
            // cmbxProductCategory
            // 
            this.cmbxProductCategory.FormattingEnabled = true;
            this.cmbxProductCategory.Items.AddRange(new object[] {
            "Electronics",
            "Home",
            "Books",
            "Toys"});
            this.cmbxProductCategory.Location = new System.Drawing.Point(107, 100);
            this.cmbxProductCategory.Name = "cmbxProductCategory";
            this.cmbxProductCategory.Size = new System.Drawing.Size(279, 28);
            this.cmbxProductCategory.TabIndex = 4;
            this.cmbxProductCategory.Text = "Electronics";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(107, 53);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(288, 26);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.Text = "Television";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(25, 152);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Price";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(25, 103);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 20);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // btnProductCreate
            // 
            this.btnProductCreate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProductCreate.Location = new System.Drawing.Point(333, 308);
            this.btnProductCreate.Name = "btnProductCreate";
            this.btnProductCreate.Size = new System.Drawing.Size(143, 37);
            this.btnProductCreate.TabIndex = 2;
            this.btnProductCreate.Text = "Create";
            this.btnProductCreate.UseVisualStyleBackColor = false;
            this.btnProductCreate.Click += new System.EventHandler(this.btnProductCreate_Click);
            // 
            // btnProductCancel
            // 
            this.btnProductCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProductCancel.Location = new System.Drawing.Point(51, 309);
            this.btnProductCancel.Name = "btnProductCancel";
            this.btnProductCancel.Size = new System.Drawing.Size(146, 36);
            this.btnProductCancel.TabIndex = 3;
            this.btnProductCancel.Text = "Cancel";
            this.btnProductCancel.UseVisualStyleBackColor = false;
            this.btnProductCancel.Click += new System.EventHandler(this.btnProductCancel_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 404);
            this.Controls.Add(this.btnProductCancel);
            this.Controls.Add(this.btnProductCreate);
            this.Controls.Add(this.productGroupBox);
            this.Name = "ProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.productGroupBox.ResumeLayout(false);
            this.productGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrProductPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox productGroupBox;
        private System.Windows.Forms.NumericUpDown nmrProductPrice;
        private System.Windows.Forms.ComboBox cmbxProductCategory;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnProductCreate;
        private System.Windows.Forms.Button btnProductCancel;
    }
}