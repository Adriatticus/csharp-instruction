using ConsoleLibrary;

namespace csharp_substring_index_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string letters = "abcdefg";
            string first3Letters = letters.Substring(0, 3);
            MyConsole.PrintL($"first 3 letters: {first3Letters}");
            MyConsole.PrintL($"next 3 letters: {letters.Substring(3,3)}");
            MyConsole.PrintL($"last letter: {letters.Substring(6,1)}");

            string fullName = "Robert Nesta Marley";
            // first, midle, and last names
            // where the spaces are
            int firstSpace = fullName.IndexOf(" ");
            MyConsole.PrintL($"firstSpace = {firstSpace}" ); //6
            int secondSpace = fullName.IndexOf(" ", firstSpace+1);
            MyConsole.PrintL($"secondSpace = {secondSpace}"); //12

            string firstName = fullName.Substring(0, firstSpace);
            MyConsole.PrintL($"firstName = {firstName}.");
            string middleName = fullName.Substring(firstSpace+1, secondSpace - firstSpace-1);
            MyConsole.PrintL($"middleName = {middleName}.");
            string lastName = fullName.Substring(secondSpace+1);
            MyConsole.PrintL($"lastName = {lastName}.");

            MyConsole.PrintL($"c position = {fullName.IndexOf('x')}");




            MyConsole.Print("\nStuff");
        }
    }
}
