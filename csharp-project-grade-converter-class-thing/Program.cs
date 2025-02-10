namespace csharp_project_grade_converter_class_thing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I'm quite afraid that perhaps I'm not supposed to exist and someone will find me and delte me! Oh dear!\n");

            string choice = "y";
            while (choice == "y" || choice == "Y") // || means 'or' //can do choice.ToLower() == y
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
