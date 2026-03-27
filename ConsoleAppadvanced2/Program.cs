namespace ConsoleAppadvanced2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCatalog catalog = new ProductCatalog();

            var result = SearchProduct.SearchProducts(catalog.Products, p => p.Price < 50);
            Console.WriteLine("---under$50 —");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name}, {item.Price}, {item.Stock}");
            }
            Console.WriteLine();
            var electronics = SearchProduct.SearchProducts(catalog.Products, p => p.Category == "Electronics");
            Console.WriteLine("---Electronics —");
            
            foreach (var item in electronics)
            {
                Console.WriteLine($"{item.Name}, {item.Price}, {item.Stock}");
            }
            Console.WriteLine();
            Console.WriteLine("--- Short Report ---");
            PrintReport.PrintProductReport(catalog.Products,p=> {Console.WriteLine($"{p.Name} - ${p.Price}");});
            Console.WriteLine();
            Console.WriteLine("\n--- Detailed Report ---");
            PrintReport.PrintProductReport(catalog.Products, p =>
            {
                Console.WriteLine($"Name: {p.Name} | Category: [{p.Category}] | Price: ${p.Price} |  Stock: {p.Stock}  ");
            });
            Console.WriteLine();
            Console.WriteLine("--- Summary List ---");
            var summary=TransformProduct.TransformProducts(catalog.Products, p => $"{p.Name} (${p.Price})");
            foreach( var item in summary)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine();
            Console.WriteLine("\n--- Price Labels ---");
            var labels = TransformProduct.TransformProducts(catalog.Products, p => p.Price > 100 ? "Expensive" : "Affordable");
            for (int i = 0; i < catalog.Products.Count; i++) 
            {
                Console.WriteLine($"{catalog.Products[i].Name}: {labels[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("--- Low-Stock Alert ---");
            var lowStock = FilterProduct.FilterProducts(catalog.Products, p => p.Stock < 20);
            foreach(var item in lowStock)
            {
                Console.WriteLine($"[LOW STOCK] {item.Name}: only {item.Stock} left!");
            }



        }
    }
}
    

