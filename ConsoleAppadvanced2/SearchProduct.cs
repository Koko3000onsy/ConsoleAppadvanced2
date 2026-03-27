using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppadvanced2
{
    public static class SearchProduct
    {
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        {
            List<Product> result = new List<Product>();

            foreach (var product in products)
            {
                if (filter(product))
                {
                    result.Add(product);
                }
            }

            return result;
        }

    }
}
