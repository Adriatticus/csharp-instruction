using ConsoleLibrary;

namespace csharp_chapter15_demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, In your faces!\n");

            List<ISummarizable> things = new List<ISummarizable>();
            // create some products

            Product p1 = new Product("c#", "Murach's C#", 53.99m);
            Product p2 = new Product("mysql", "Murach's MySQL", 44.99m);
            Product p3 = new Product("andr", "Murach's Android", 59.99m);
            things.Add(p1);
            things.Add(p2);
            things.Add(p3);

            //create some customers

            Customer c1 = new Customer("Adrian", "Johnson", "AJ0001");
            Customer c2 = new Customer("Celina", "Saksith", "CS0001");
            things.Add(c1);
            things.Add(c2);



            // print a summary
            MyConsole.PrintL("--- Summary -------------------------------");
            foreach (var item in things)
            {
                MyConsole.PrintL($"{item.GetSummaryDetails()}");
                
            }
            MyConsole.PrintL("------------------------------------------");

            // list of products
            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            MyConsole.PrintL("=============== All Products ===============");
            foreach (Product p in products)
            {
                MyConsole.PrintL(p.GetSummaryDetails()); 
            }

            products.Sort();
            MyConsole.PrintL("=============== Sorted Products ============");
            foreach (Product p in products)
            {
                MyConsole.PrintL(p.GetSummaryDetails());
            }


            MyConsole.PrintL("\nGet outta my face!");
        }
    }
}
