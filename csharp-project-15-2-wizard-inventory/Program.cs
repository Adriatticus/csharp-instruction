using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic;

namespace csharp_project_15_2_wizard_inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What does Malavander's bag of holding hold today?\n");

            PrintL("The Wizard Inventory game\n");

            List<string> inventory = new List<string>(4) { "Four Leather Belt", "Gnarled Enchanted Staff", "Health Potion" };
            /*
            foreach (string i in inventory)
            {
                Console.Write(i + ", " );
            }
            */

            /*
            for(int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"i: {i}, {inventory[i]}");

            }
            Console.WriteLine($"elemnt at index 2: {inventory[2]}");
            */

            PrintL("COMMAND MENU");
            PrintL("show - Show all items");
            PrintL("grab - Grab an Item");
            PrintL("edit - Edit an item");
            PrintL("drop - Drop an item");
            PrintL("exit - Exit Program\n");

            string CommandW = "";
            while (CommandW != "exit")
            {


                Print("\nCommand: ");
                CommandW = Console.ReadLine().ToLower();

                switch (CommandW)
                {
                    case "show":
                        for (int i = 0; i < inventory.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {inventory[i]}");

                        }
                        break;

                    case "grab":
                        if (inventory.Count >= 4)
                        {
                            PrintL("You can't carry any more items. Drop something first");
                        }
                        else
                        {
                            Print("Name: ");
                            string grab = Console.ReadLine();
                            inventory.Add(grab);
                            PrintL($"{grab} was added");
                        }
                        break;
                    case "edit":
                        Print("Number: ");
                        int renameit = CheckNbr();
                        if (renameit != 0)
                        {
                       Print("Updated name: ");
                        string newName = Console.ReadLine();
                        inventory[renameit - 1] = newName;
                        }
                        break;

                    case "drop":
                        int drop = CheckNbr();
                        if (drop != 0)
                        {
                            inventory.RemoveAt(drop - 1);
                        }
                        break;



                }

                static int CheckNbr()
                {
                    Print("Number: ");
                    int dropIt = 0;
                    bool successDrop = int.TryParse(Console.ReadLine(), out dropIt);
                    if (!successDrop)
                    {
                        Print("Choose inventory slot 1, 2, 3 or 4");
                        return 0;
                    }
                    else if (dropIt < 1 || dropIt > 4)
                    {
                        Print("Choose inventory slot 1, 2, 3 or 4");
                        return 0;
                    }
                    return dropIt;
                }





            }




            //need inventory
            // read about array lists / check chapter 8 demos? 7?
            // just do an array with [4] since that's the most Malavander can carry
            //command menue switches p.145
            //switches for commands
            //commands - crud - create, read, update, delete
            // 1) Show all items - read
            // print array list
            // 2) Grab an item - create
            // prompt for name of item being created
            // update array list - malavander can litteraly conjure whatever he wants??!?!?!
            // attempts to create a new item - error message if limit of 4 if being exceeded
            // output that "name of item" has been added or created
            // 3) Edit - Update
            // also update array list?
            // promt for array #
            // this will prompt for a rename of an item
            // output that the item has been updated or transmogrified
            // 4) Drop - Delete
            //promt for array number
            //delete the item
            //output a message that item was dropped
            // 5) Exit - exit
            //end program


            //Seans notes to help this project: How to get something from a list from an index position






            Print("\nWhat mystical marvels will Malavander reveal next time?");
        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }
        static void PrintL(string msg)
        {
            Console.WriteLine(msg);
        }
        //static string ValidateInt()

    }
}

