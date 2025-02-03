namespace csharp_project_2_2_grade_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Nothing to see here other than a casual boot camp grade converter!");
            Console.WriteLine("\nWelcome to the Letter Grade Converter");

            string choice = "y";
            while (choice == "y" || choice == "Y") // || means 'or'
            {
                Console.Write("\nEnter numerical grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                string lettergrade = "F";


                if (grade >= 88)
                {
                    lettergrade = "A";
                }
                else if (grade >= 80)
                {
                    lettergrade = "B";
                }
                else if (grade >= 68)
                {
                    lettergrade = "C";
                }
                else if (grade >= 60)
                {
                    lettergrade = "D";
                }
                else
                {
                    lettergrade = "F";
                }
                Console.Write("Letter grade: " + lettergrade);
                Console.Write("\n\nContinue? (y/n): ");
                choice = Console.ReadLine();
            }
            

        }
    }
}
