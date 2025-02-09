using System.Text;

namespace csharp_chapter_9_demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello chapter 9!");

            // what's the current-date and time?
            DateTime currentDateTime = DateTime.Now;
            // what's the current date?
            DateTime today = DateTime.Today;
            // string concatination
            PrintL("Current date = " + currentDateTime);
            // string interpolation
            PrintL($"Current date = {currentDateTime}");
            PrintL($"Today = {today}");

            // p. 277
            PrintL($"longDate: {currentDateTime.ToLongDateString()}");
            PrintL($"longTime: {currentDateTime.ToLongTimeString()}");
            PrintL($"shortDate: {currentDateTime.ToShortDateString()}");
            PrintL($"shortTime: {currentDateTime.ToShortTimeString()}");

            // p. 279 get information about a date

            PrintL($"Month: {currentDateTime.Month}");
            PrintL($"Day: {currentDateTime.Day}");
            PrintL($"DayOfWeek: {currentDateTime.DayOfWeek}");
            PrintL($"DayOfYear: {currentDateTime.DayOfYear}");
            PrintL($"Year: {currentDateTime.Year}");
            PrintL($"Days in month: {DateTime.DaysInMonth(2025, 2)}");
            PrintL($"Leapyear - 2028: {DateTime.IsLeapYear(2028)}");

            // p.281 manipulate dates and time
            // due date in 2 months

            DateTime dueDate = currentDateTime.AddMonths(2);
            PrintL($"Due date: {dueDate}");

            //Halloween
            DateTime halloween = new DateTime(2025, 10, 31);
            PrintL($"Halloween = {halloween}");

            PrintL($"Halloween > today {halloween > currentDateTime}");
            TimeSpan timeTilHalloween = halloween.Subtract(currentDateTime);
            PrintL($"Days until Halloween {timeTilHalloween.Days}");

            // Strings p. 285
            // loop through characters in a string

            string sentence = "Woohoo! So glad today is Friday!";
            foreach (char c in sentence)
            {
                Print(c + " ");
            }

            //hangman - creating and underscore version of a word
            // word is "superman", the hiddenVersion would be "_ _ _ _ _ _ _ _"
            string word = "superman";
            string hiddenVersion = "";
            foreach (char c in word)
            {
                hiddenVersion += " _ ";
            }
            hiddenVersion = hiddenVersion.Trim();
            PrintL($"\nword: {word}");
            PrintL($"hidden word: {hiddenVersion}");

            // p. 293
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(", how ");
            sb.Append("are you?");
            PrintL(sb.ToString());












            Console.WriteLine("Goodbye chapter 9!");
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

