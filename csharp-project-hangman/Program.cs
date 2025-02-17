using ConsoleLibrary;

namespace csharp_project_hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Goodbye hanged man!\n");

            string hangedMan = MyConsole.PrintL(@"""
            ______________________
               \|/            |
                |             |
                |             WWWWW
                |             | x x
                |           __/\_c/
                |          / /       
                |          | |
                |
                |                     
                |                     
                |
               /|\
            __/_|_\____________________
            |                         |
            MyConsole.PrintL("\nHanged man? Can you hear me?\n...");
        }
    }
}
