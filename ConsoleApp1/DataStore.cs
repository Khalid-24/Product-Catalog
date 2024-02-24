using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;



namespace ConsoleApp1
{
    public static class DataStore
    {
       
        public static Catalog Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                Catalog catalog = new Catalog();

                foreach (string line in lines)
                {
                    string[] fields = line.Split('\t');

                    if (fields.Length == 3)
                    {
                        Product product = new Product
                        {
                            Name = fields[0],
                            Price = decimal.Parse(fields[1]),
                            Department = (Department)int.Parse(fields[2])
                        };

                        catalog.Add(product);
                    }
                }

                return catalog;
            }
            else
            {
                throw new FileNotFoundException("File not found.", filePath);
            }
        }

        public static void Save(Catalog catalog, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var product in catalog.GetAllProducts())
            {
                string line = $"{product.Name}\t{product.Price}\t{(int)product.Department}";
                sb.AppendLine(line);
            }

            File.WriteAllText(filePath, sb.ToString());
        }
    }
}
