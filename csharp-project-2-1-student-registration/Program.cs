namespace csharp_project_2_1_student_registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Well hey there, Project 2-1: Student Registration!");

            string sentence = "\nStudent Registration Form\n";

            Console.WriteLine(sentence);
            Console.WriteLine("Enter first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter year of birth: ");
            string birthy = Console.ReadLine();
            string welcome = "\nWelcome " + fname + " " + lname + "!" + "\nYour registration is complete." + "\nYour temporary password is: " + fname + "*" + birthy;
            Console.WriteLine(welcome);

            Console.WriteLine("\nGood luck out there!!!");
        }
    }
}
