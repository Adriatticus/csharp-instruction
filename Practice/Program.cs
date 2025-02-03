namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is me practicing the demos");

            string sentence = "Student Registration Form\n";
            Console.WriteLine(sentence);
            Console.WriteLine("Enter first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter year of birth: ");
            string birthy = Console.ReadLine();
            string welcome = "\nWelcome "+fname + " " + lname+"!" + "\nYour registration is complete." + "\nYour temporary password is: "+fname+"*"+birthy;
            Console.WriteLine(welcome);

            Console.WriteLine("\nGreat job! See ya later!");
        }
    }
}
