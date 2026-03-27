using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppadvanced2
{
    public class FilterProduct
    {
        public static List<Product>FilterProducts(List<Product> products, Predicate<Product> filter)
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
