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
            PrintIntList(numbers);

            MyConsole.PrintL("");

            // int doubleNumbers = make a new list that is every number in the list times 2

            List<int> doubleNumbers = new List<int>();
            foreach (int var in numbers) 
            {
                doubleNumbers.Add(var * 2);
            }
            PrintIntList(doubleNumbers);

            MyConsole.PrintL("");


            List<int> evenNumbers = new List<int>();
            foreach (int var in numbers)
            {
                if (var % 2 == 0)
                {
                    evenNumbers.Add(var);
                }
            }
            PrintIntList(evenNumbers);
            

            MyConsole.PrintL("");

            List<string> names = new List<string>() {"jim", "nick", "andy", "christian", "adiran", "sean", "celina", "joe", "heath"};
            PrintList(names);

            int stringLength = (names.Count());
            MyConsole.PrintL(stringLength.ToString());

            MyConsole.PrintL("");

            List<string> titleNames = new List<string>();
            foreach (string name in names)
            {
                titleNames.Add(Titlize(name));
                
            }
            PrintList(titleNames);

            MyConsole.PrintL("");

            List<string> filteredNames = new List<string>();
            foreach (string name in titleNames)
            {
                if (FilterAC(name))
                {
                filteredNames.Add(name);
                }
            }
            PrintList(filteredNames);

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

        public static void PrintList(List<string> stringList)
        {
            foreach (string value in stringList)
            {
                MyConsole.Print($"{value.ToString()}, ");
            }
        }

        public static void PrintIntList(List<int> intList)
        {
            foreach (int value in intList)
            {
                MyConsole.Print($"{value.ToString()}, ");
            }
        }

        public static bool FilterAC(string name)
        {
            string firstChar = name.Substring(0, 1);
            if (firstChar == "A" || firstChar == "C")
            {
                return true;
            }
            return false;
        }
    }
}
