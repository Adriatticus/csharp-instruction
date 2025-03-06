using ConsoleLibrary;
using System.Diagnostics.CodeAnalysis;

namespace csharp_array_vs_list_vs_arraylist_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyConsole.PrintL("Arrays, lists, arraylists!\n");

            // process a set of numbers, 1 to 10, using arrays
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // loop through numbers, printing to the console
                string outputStr = "";
                int sum = 0;
            foreach (int i in numbers)
            {
                outputStr += i.ToString() + " ";
                sum += i;
                //MyConsole.Print($"{i}, ");
            }
                MyConsole.PrintL(outputStr);
                MyConsole.PrintL($"sum = {sum}");

            // add 11 through 15?
            numbers = numbers.Append(11).ToArray();

            Array.ForEach(numbers, i => { MyConsole.Print(i.ToString() + " "); });
            MyConsole.PrintL("");

            // change an ellement within an array: at position 5, multiply the value by 10?

            numbers[5] = numbers[5] * 10;
            Array.ForEach(numbers, i => { MyConsole.Print(i.ToString() + " "); });

            MyConsole.PrintL("\n============== Lists ============");

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //nums.Add(1);
            sum = 0;
            string numsStr = "";
            foreach (int i in nums)
            {
                //MyConsole.Print($"{i}, ");
                numsStr += $"{i}, ";
                sum += i;
            }
            numsStr = numsStr.Substring(0, numsStr.Length -2);
            MyConsole.PrintL(numsStr);
            MyConsole.PrintL($"sum = {sum}");

            // add 11 to the end
            nums.Add(11);
            nums.ForEach(nums=> { MyConsole.Print($"{nums}, "); });

            // change an elemint within a list: at position 5, remove and element from a list

            nums[5] = nums[5] * 10;
            nums.ForEach(nums => { MyConsole.Print($"{nums}, "); });
            MyConsole.PrintL("");
            // and remove [5]
            nums.RemoveAt(5);
            nums.ForEach(nums => { MyConsole.Print($"{nums}, "); });
            MyConsole.PrintL("");

            // ============================== ArrayList ============================================ //

                                //Are obsolete so don't use them!!!!!!!!!!!//

            // Create some products

            Product p1 = new Product(1, "c#", "Murach's C#", 54.99m);
            Product p2 = new Product(2, "java", "Murach's Jave", 55.99m);
            Product p3 = new Product(3, "mysql", "Murach's MySQL", 45.99m);

            List<Product> products = new List<Product>() { p1, p2, p3 };

            // loop through the list and list the details.

            //foreach (Product p in products)
            //{
            //    MyConsole.PrintL(p.ToString());
            //}

            products.ForEach(p => MyConsole.PrintL(p.ToString()));

            // CRUD on a list
            // - Adding an element to the list
            Product p4 = new Product(10989, "test", "Test Book", 77.77m);
            products.Add(p4);
            products.ForEach(p => MyConsole.PrintL(p.ToString()));
            // - Get an element from the list - w/ code 99
            Product p = null;
            foreach (Product prod in products)
            {
                if (prod.ProductID == 10989)
                {
                    p = prod;
                    break;
                }
            }
            MyConsole.PrintL($"Product found! : {p.ToString()}");

            // - Update and element in a list
            foreach (Product prod in products)
            {
                if (prod.ProductID == 10989)
                {
                    //prod.Code = "TEST";
                    products.Remove(prod);
                    break;
                }
            }

            products.ForEach(p => MyConsole.PrintL(p.ToString()));
            // - Delete and element from the list



            





            MyConsole.PrintL("\nwhere do you goodbye at?");
        }
    }
}
