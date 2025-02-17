using ConsoleLibrary;
using Microsoft.VisualBasic;

namespace csharp_dictionary_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, stolen land!!!");

            Dictionary<string, string> usStates = new Dictionary<string, string>();
            // Add - adds an entry, throws an exception if already exists
            usStates.Add("OH", "Ohio");
            // [] Indexer - sets this positin in the dictionary, replaces entry if already exists
            usStates["IN"] = "Indiana";
            MyConsole.PrintL("Enter some US States. Enter EX to exit");
            MyConsole.PrintL("=======================================");
            string stateAbbreviation = "";
            while (stateAbbreviation != "EX")
            {
                stateAbbreviation = MyConsole.PromptString("State Abbreviation: ").ToUpper();
                    if (stateAbbreviation == "EX")
                        break;

                string stateName = MyConsole.PromptString("State Name: ");
                //usStates.Add(stateAbbreviation, stateName);
                usStates[stateAbbreviation] = stateName;
            }

            MyConsole.PrintL("GetAdd stats");
            MyConsole.PrintL($"Key OH = {usStates["OH"]}");

            MyConsole.PrintL("Display all keys:");
            //List <string> states = new List<string>(usStates.Keys);
            foreach (string s in usStates.Keys)
            {
                MyConsole.Print(s + ", ");

            }
            MyConsole.PrintL("");

            MyConsole.PrintL("Display all values");
            foreach (string s in usStates.Values)
            {
                MyConsole.Print(s + ", ");

            }
            MyConsole.PrintL("");

            MyConsole.PrintL("\nKey Value Pairs");
            foreach (KeyValuePair<string, string> entry in usStates)
            {
                MyConsole.Print($"{entry.Key} - {entry.Value}");

            }
            MyConsole.PrintL("");

            MyConsole.PrintL("Remove and entry:\n");
            usStates.Remove("OH");

            MyConsole.PrintL("\nKey Value Pairs");
            foreach (KeyValuePair<string, string> entry in usStates)
            {
                MyConsole.Print($"{entry.Key} - {entry.Value}");
            }
            MyConsole.PrintL("");
            
            MyConsole.PrintL("Display entire Dictionary:");

            MyConsole.PrintL("Goodbye! freedom!");
        }
    }
}
