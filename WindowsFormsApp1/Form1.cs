using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyForm : Form
    {
        public Catalog catalog = new Catalog();
        public MyForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtCatalog.Text))
            {
                catalog = DataStore.Load(txtCatalog.Text);
                RefreshProductGrid();
            }
            else
            {
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void chkbxAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxAutoSave.Checked)
            {
                DataStore.Save(catalog, txtCatalog.Text);
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            ;
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text;
            dgvProducts.DataSource = new BindingList<Product>(catalog.GetProducts(filter).ToList());
        }

        private void btnCreateProduct_Click_1(object sender, EventArgs e)
        {
            var productForm = new ProductForm();
            productForm.ProductCreated += ProductForm_ProductCreated;
            productForm.ShowDialog();
        }
        private void ProductForm_ProductCreated(object sender, ProductEventArgs e)
        {
            catalog.Add(e.NewProduct);
            DataStore.Save(catalog, txtCatalog.Text); // Save the updated catalog
            RefreshProductGrid();
        }

        private void RefreshProductGrid()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = new BindingList<Product>(catalog.GetAllProducts().ToList());

        }

        private void nmrAutoSave_ValueChanged(object sender, EventArgs e)
        {
            //int intervalMinutes = (int)nmrAutoSave.Value;
            //int intervalMilliseconds = intervalMinutes * 60 * 1000; // Convert to milliseconds

            //autoSaveTimer.Interval = intervalMilliseconds;
        }

        private void txtCatalog_TextChanged(object sender, EventArgs e)
        {

        }

        private void MyForm_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = null;
        }
    }
}
