using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppadvanced2
{
    public class TransformProduct
    {
        public static List<T> TransformProducts<T>(List<Product> products, Func<Product, T> transform)
        {
            List<T> result = new List<T>();
            foreach (var product in products)
            {
                result.Add(transform(product));
            }
            return result;
        }
    }
}
