namespace csharp_project_7_1_contact_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!? Are you there? You're on my contacts.");

            Console.WriteLine("If you haven't already been ghosted here's your Contact List application\n");

            string choice = "y";
            while (choice == "y")
            {
            string firstName = MyConsole.PromptString("Enter first name:\t");
            string lastName = MyConsole.PromptString("Enter last name:\t");
            string email = MyConsole.PromptString("Enter email:\t\t");
            string phone = MyConsole.PromptString("Enter phone:\t\t");

            Contact contact0 = new Contact(firstName, lastName, email, phone);
            contact0.DisplayContact();
                choice = MyConsole.PromptString("Continue? y/n ").ToLower();
            } 
            MyConsole.PrintL("\nNew contacts who's this?");
        }
    }
}
