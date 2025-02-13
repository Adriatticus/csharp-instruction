using ConsoleLibrary;

namespace csharp_project_7_2_grade_converter_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Teach! All A's?\n");

            Console.WriteLine("Welcome to the Letter Grade Converter\n");

            // while choice == y
            string choice = "y";
            while (choice.ToLower() == "y")
            {
                int numericGrade = MyConsole.PromptIntInRange(($"Enter numerical grade: "), 0, 100);
                Grade grade = new Grade();
                MyConsole.PrintL($"Letter grade: {grade.GetLetter()}");
                choice = MyConsole.PromptStrInRange("Continue? (y/n): ", "y", "n");
            }
            Console.WriteLine("All C's?! C's get degrees I guess.");
        }
    }
}
