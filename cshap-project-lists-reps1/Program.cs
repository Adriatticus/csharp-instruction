using ConsoleLibrary;
using System.Runtime.InteropServices;

namespace cshap_project_lists_reps1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Protien!\n");

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // int doubleNumbers = make a new list that is every number in the list times 2

            List<int> doubleNumbers = new List<int>();
            foreach (int var in numbers) 
            {
                doubleNumbers.Add(var * 2);
            }
            foreach (int var in doubleNumbers)
            {
                MyConsole.Print($"{var.ToString()}, ");
            }

            MyConsole.PrintL("");


            List<int> evenNumbers = new List<int>();
            foreach (int var in numbers)
            {
                if (var % 2 == 0)
                {
                    evenNumbers.Add(var);
                }
                
            }
            foreach (int var in evenNumbers)
            {
                MyConsole.Print($"{var.ToString()}, ");
            }

            MyConsole.PrintL("");

            List<string> names = new List<string>() {"jim", "nick", "andy", "christian", "adiran", "sean", "celina", "joe", "heath"};

            List<string> titleNames = new List<string>();
            foreach (string name in names)
            {
                titleNames.Add(Titlize(name));
            }
            foreach(string name in titleNames)
            {
                MyConsole.Print($"{name}, ");
         
            }

            MyConsole.PrintL("");

            List <string> filteredNames = new List<string>();
            foreach (string name in titleNames)
            {
                filteredNames.Add(name);
                    
            }




            MyConsole.PrintL("\n\nProtien!!!");
        }

        public static string Titlize(string nameVariable)
        {
            //string nameVariable = ("");
            string firstUpper = nameVariable.Substring(0, 1).ToUpper();
            string restLower = nameVariable.Substring(1).ToLower();
            string title = firstUpper + restLower;
            return title;
        }
    }
}
