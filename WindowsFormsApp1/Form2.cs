using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductForm : Form
    {
        public event EventHandler<ProductEventArgs> ProductCreated;

        public ProductForm()
        {
            InitializeComponent();
            cmbxProductCategory.DataSource = Enum.GetValues(typeof(Department));
        }

        private void btnProductCreate_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text;
            Department category = (Department)cmbxProductCategory.SelectedItem;
            decimal price = nmrProductPrice.Value;

            Product newProduct = new Product
            {
                Name = name,
                Department = category,
                Price = price
            };

            ProductCreated?.Invoke(this, new ProductEventArgs(newProduct));

            Close();

        }

        private void btnProductCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
