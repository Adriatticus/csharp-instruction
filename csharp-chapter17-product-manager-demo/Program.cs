using ConsoleLibrary;

namespace csharp_chapter17_product_manager_demo
{
    internal class Program
    {
        static List<Product> products = new List<Product>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Get managed on!!\n");

            MyConsole.PrintL("Welcome to the product manager\n");

            // Program that provides CRUD features for products
            // Products will be stored in a text file names products.txt

            // load products from file
            products = ProductDB.GetProducts();

            int command = 9;
            while (command != 0)
            {
                DisplayMenu();
                command = MyConsole.PromptInt("Command: ");
                switch (command)
                {
                    case 1:
                        ListProducts();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        RemoveProduct();
                        break;
                    //case 4:
                    //    RealRemoveProduct();
                        break;
                    case 0:
                        break;
                    default:
                        MyConsole.PrintL("Invalid Command. Try again.");
                        break;
                }
            }

            MyConsole.PrintL("\nYou have been managed.");
        }

        private static void AddProduct()
        {
            MyConsole.PrintL("\nAdd Product:");
            MyConsole.PrintL("==============================");
            string code = MyConsole.PromptString("Code: ");
            string desc = MyConsole.PromptString("Description: ");
            decimal price = MyConsole.PromptDecimal("Price: ");
            Product p = new Product(code, desc, price);
            products.Add(p);
            ProductDB.SaveProducts(products);
            MyConsole.PrintL("Product added.");
        }

        private static void ListProducts()
        {
            MyConsole.PrintL("\nList Products:");
            MyConsole.PrintL("==============================");
            foreach (Product p in products)
            // check to see if list is not empty
            {
                MyConsole.PrintL(p.ToString());
            }

        }

        static void DisplayMenu()
        {
            MyConsole.PrintL("\nCOMMAND MENU:");
            MyConsole.PrintL("1) List Products");
            MyConsole.PrintL("2) Add Product");
            MyConsole.PrintL("3) Remove Product (foreach)");
            //MyConsole.PrintL("4) Real Remove Product (for)");
            MyConsole.PrintL("0) Exit");
        }

        private static void RemoveProduct()
        {
            MyConsole.PrintL("\nRemove Product:");
            MyConsole.PrintL("==============================");
            string code = MyConsole.PromptString("Code: ");
            foreach (Product p in products)
            {
                if (p.Code == code)
                {
                    products.Remove(p);
                    break;
                }
            }
            ProductDB.SaveProducts(products);
            MyConsole.PrintL("Product removed.");
        }

        private static void RealRemoveProduct()
        {
            MyConsole.PrintL("\nRemove Product:");
            MyConsole.PrintL("==============================");
            string code = MyConsole.PromptString("Code: ");
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Code == code)
                {
                    products.RemoveAt(i);
                    break;
                }
                ProductDB.SaveProducts(products);
                MyConsole.PrintL("Product removed.");
            }
        }

    }
}



