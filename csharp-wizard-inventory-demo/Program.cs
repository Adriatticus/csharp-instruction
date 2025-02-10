using System.Data;

namespace csharp_wizard_inventory_demo
{
    internal class Program
    {
        static List<string> items = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Wizard Inventory Game demo with teach!!!");

            items.Add("wooden staff");
            items.Add("wizard hat");
            items.Add("cloth shoes");

            string command = " ";
            while (command != "exit")
            {
                DisplayMenu();
                Print("Command: ");
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "show":
                        ShowItem();
                        break;

                    case "grab":
                        GrabItem();
                        break;

                    case "edit":
                        EditItem();
                        break;

                    case "drop":
                        DropItem();
                        break;

                    case "exit":
                        break;

                }
                PrintL("");
            }

            //while
            // display menu
            //promt command
            //evaluate command : show, grab, edit, or drop item(s)
            //stop loop? command == "exit"


            PrintL("Safe travles adventurer!");
        }

        private static void DropItem()
        {
            PrintL("Drop and Item: ");
            PrintL("==============");
            int itemNumber = PromptInt("Item # to Drop: ", 1, items.Count);
            string itemName = items[itemNumber - 1];
            items.RemoveAt(itemNumber);
            PrintL($"{itemName} was removed");
        }

        private static void EditItem()
        {
            PrintL("Show All Items: ");
            PrintL("==============");
            // prompt for item number to eit
            int itemNumber = PromptInt("Item # to Edit: ", 1 , items.Count);
            // prompt for updated name
            Print("Updated name: ");
            string updatedName = Console.ReadLine();
            // edit the item at that position
            items[itemNumber - 1] = updatedName;
            // display message confirming the item number was updated
            PrintL($"Item number {itemNumber} was updated");
        }

        private static void GrabItem()
        {
            PrintL("Show All Items: ");
            PrintL("==============");
            Print("Item to add: ");
            if (items.Count >= 4)
            {
                PrintL("Carrying too many items. Drop and item first");
            }
            else
            {
            string itemName = Console.ReadLine();
                items.Add(itemName);
                PrintL($"{itemName} was added.");
            // promt for item to add
            // add to list
            }
        }

        private static void ShowItem()
        {
            PrintL("Show All Items: ");
            PrintL("==============");
            for (int i = 0; i < items.Count; i++)
            {
                PrintL($"{i + 1}. {items[i]}");
            }
        }

        static void DisplayMenu()
        {
            PrintL("COMMAND MENU");
            PrintL("=======================");
            PrintL("show - show all items");
            PrintL("grab - grab/add an item");
            PrintL("edit - edit an item");
            PrintL("drop - drop an item");
            PrintL("exit - exit the app\n");
        }
        static int PromptInt(string prompt, int min, int max)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Print(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    if (result >= min && result <= max)
                    {
                        isValid = true;
                    }
                }
                else
                {
                    PrintL("Error - entry must be a whole number");
                }

            }
            //while loop
            // print the prompt
            // get user input
            // validate whole number
            // validate range: >= min AND <=max

            return result;
        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }
        static void PrintL(string msg)
        {
            Console.WriteLine(msg);
        }

    }
}
