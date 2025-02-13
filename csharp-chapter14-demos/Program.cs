using ConsoleLibrary;

namespace csharp_chapter14_demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Bob!\n");

            string name = "Bob";
            MyConsole.PrintL(name.ToString());
            MyConsole.PrintL(name);
            int nbr1 = 11;
            MyConsole.PrintL(nbr1 + nbr1.ToString());

            Movie m1 = new Movie(1, "Test Movie", 2000, "PG", "Test Director");
            MyConsole.PrintL(m1.ToString());

            Movie m2 = new Movie(2, "Test Action Movie", 2014, "R", "Test Director");
            MyConsole.PrintL(m2.ToString());

            int nbr2 = 11;
            MyConsole.PrintL($"nbr1 == to nbr?: { nbr1 == nbr2}");
            MyConsole.PrintL($"m1 == m2?: {m1 == m2}");
            Movie m3 = new Movie(2, "Test Action Movie", 2014, "R", "Test Director");
            MyConsole.PrintL($"m2 == m3?: {m2 == m3}");

            string str1 = "abc";
            string str2 = "abc";
            MyConsole.PrintL($"str1 == str2?: {str1 == str2}");

            Movie m4 = m3;
            MyConsole.PrintL($"m3 == m4?: {m3 == m4}");

            // create instances of Product
            //Product p1 = new Product("c#", "Murach's C#", 54.99m);
            //Product p2 = new Product();
            //MyConsole.PrintL(p1.GetDisplayText("|"));

            Book b1 = new Book("java", "Murach's Java", 49.99m, "Joel Murach");
            MyConsole.PrintL(b1.GetDisplayText("|"));

            Software s1 = new Software("vs", "Visual Studio", 0.0m, "8.8");
            MyConsole.PrintL(s1.GetDisplayText("|"));

            Book b2 = new Book("c#", "Murach's C#", 54.99m, "Mike Murach");
            Book b3 = new Book("andr", "Murach's Android", 59.99m, "Joel Murach");

            List<Product> products = new List<Product>();
            products.Add(b1);
            products.Add(b2);
            products.Add(s1);
            products.Add(b3);

            MyConsole.PrintL("\n-----------------Products Summary-----------------------");

            foreach(Product p in products)
            {
                MyConsole.PrintL(p.GetDisplayText("|"));
            }




            MyConsole.PrintL("\nSee ya later Bob!");
        }
    }
}
