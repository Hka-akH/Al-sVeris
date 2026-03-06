using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    internal class Cart
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"{product.Name} Sepete Eklendi ");
        }
        public decimal GetTotalPrice()
        {
            return products.Sum(p => p.Price);
        }
    }
}
