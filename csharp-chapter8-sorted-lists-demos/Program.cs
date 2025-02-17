using ConsoleLibrary;

namespace csharp_chapter8_sorted_lists_demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Lists! Prepare to get sorted on\n");

            // p. 262
            // create a SortedList of usStates
            SortedList<string, string> usStates = new SortedList<string, string>();
            usStates.Add("OH", "Ohio");
            usStates["IN"] = "Indiana";
            usStates.Add("CO", "Colorado");
            usStates.Add("CA", "California");
            usStates.Add("MI", "Michigan");

            // get all entries
            foreach (KeyValuePair<string, string> state in usStates)
            {
                MyConsole.PrintL($"{state.Key}: {state.Value}");
            }

            // get all keys
            foreach (string s in usStates.Keys)
            {
                MyConsole.PrintL(s + "|");
            }
            MyConsole.PrintL("");

            //get all values
            foreach (string s in usStates.Values)
            {
                MyConsole.PrintL(s + "|");
            }
            MyConsole.PrintL("");

            //usStates.Remove();

            // p. 263 collection initializer
            //usStates = new SortedList<string, string>{ {"OH", "Ohio" }, {"IN", "Indiana" },
            //    {"CO", "Colorado" }, {"MI", "Michigan" }, {"AL", "Alabama" }, {"HI", "Hawaii" } };

            usStates = new SortedList<string, string>
            {
                { "AL", "Alabama" }, { "AK", "Alaska" }, { "AZ", "Arizona" }, { "AR", "Arkansas" },
                { "CA", "California" }, { "CO", "Colorado" }, { "CT", "Connecticut" }, { "DE", "Delaware" },
                { "FL", "Florida" }, { "GA", "Georgia" }, { "HI", "Hawaii" }, { "ID", "Idaho" },
                { "IL", "Illinois" }, { "IN", "Indiana" }, { "IA", "Iowa" }, { "KS", "Kansas" },
                { "KY", "Kentucky" }, { "LA", "Louisiana" }, { "ME", "Maine" }, { "MD", "Maryland" },
                { "MA", "Massachusetts" }, { "MI", "Michigan" }, { "MN", "Minnesota" }, { "MS", "Mississippi" },
                { "MO", "Missouri" }, { "MT", "Montana" }, { "NE", "Nebraska" }, { "NV", "Nevada" },
                { "NH", "New Hampshire" }, { "NJ", "New Jersey" }, { "NM", "New Mexico" }, { "NY", "New York" },
                { "NC", "North Carolina" }, { "ND", "North Dakota" }, { "OH", "Ohio" }, { "OK", "Oklahoma" },
                { "OR", "Oregon" }, { "PA", "Pennsylvania" }, { "RI", "Rhode Island" }, { "SC", "South Carolina" },
                { "SD", "South Dakota" }, { "TN", "Tennessee" }, { "TX", "Texas" }, { "UT", "Utah" },
                { "VT", "Vermont" }, { "VA", "Virginia" }, { "WA", "Washington" }, { "WV", "West Virginia" },
                { "WI", "Wisconsin" }, { "WY", "Wyoming" } 
            };

            MyConsole.PrintL("================== all 50 States==================");
            string sa = "";
            while (sa != "EX")
            {
                sa = MyConsole.PromptString("State Abbrev: ").ToUpper();
                if (sa == "EX") break;
                string sn = "";
                try
                {
                    sn = usStates[sa];
                }
                catch (Exception)
                {
                    MyConsole.PrintL($"Error - not state for '{sa}'.");
                    continue;
                }
                MyConsole.PrintL(usStates[sa]);
            }


                // Display the states in the SortedList
                //Console.WriteLine("U.S. States Sorted List:");
                //foreach (var state in usStates)
                //{
                //    Console.WriteLine($"Abbreviation: {state.Key}, State: {state.Value}");
                //}
          
            MyConsole.PrintL("\nGet sorted!");
         
        }
        
    }

}


        
    

