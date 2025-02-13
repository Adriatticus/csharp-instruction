namespace csharp_contact_list_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reinforcements!!!!\n");
            Console.WriteLine("Welcome to the Contact List application\n");

            // while choice == y
            string choice = "y";
            while (choice == "y")
            {
                //  prompt firstName, lastName, email, phone
                string firstName = MyConsole.PromptString("Enter first name: ");
                string lastName = MyConsole.PromptString("Enter last name: ");
                string email = MyConsole.PromptString("Enter emial: ");
                string phone = MyConsole.PromptString("Enter phone: ");
                // create a Contact instance
                Contact c = new Contact(firstName, lastName, email, phone);
                // display contact info
                MyConsole.PrintL( c.DisplayContact() );
                // promt continue
                choice = MyConsole.PromptString("Continue? (y/n): ").ToLower().Trim();






            }


            Console.WriteLine("Victory!");
        }
    }
}
