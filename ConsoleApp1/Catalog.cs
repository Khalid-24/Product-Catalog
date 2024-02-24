using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Catalog
    {
        private List<Product> _list = new List<Product>();

        public void Add(Product product)
        {
            _list.Add(product);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _list;
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            return _list.Where(product => product.Name.IndexOf(filter, StringComparison.OrdinalIgnoreCase) >= 0);
        }

    }
}
