using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppadvanced2
{
    public class PrintReport
    {
        public static void PrintProductReport(List<Product> products,Action<Product>printAction)
        {
            Console.WriteLine("Product Report:");
            foreach (var product in products)
            {
                printAction(product);
            }
        }
    }
}
