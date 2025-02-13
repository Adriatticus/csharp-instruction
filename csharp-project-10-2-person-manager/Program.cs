

using ConsoleLibrary;

namespace csharp_project_10_2_person_manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, People! Prepare to be managed!\n");
            
            MyConsole.PrintL("Welcome to the Person Manager");

            string choice = "y";
            while (choice == "y")
            {
                string ce = MyConsole.PromptStrInRange("\nCreate customer or employee? (c/e): ", "c", "e");
                if (ce == "c")
                {
                    string firstName = MyConsole.PromptString("\nFirst name: ");
                    string lastName = MyConsole.PromptString("Last name: ");
                    string customerNbr = MyConsole.PromptString("Customer number: ");
                    Person newPerson = new Person(firstName, lastName);
                    Customer newCustomer = new Customer(customerNbr);
                    MyConsole.PrintL($"\nYou have entered a new Customer: ");
                    MyConsole.PrintL($"Name: {newPerson.ToString()}");
                    MyConsole.PrintL($"Customer number: {newCustomer.ToString()}");
                }
                else
                {
                    string firstName = MyConsole.PromptString("\nFirst name: ");
                    string lastName = MyConsole.PromptString("Last name: ");
                    string employeeSSN = MyConsole.PromptString("SSN: ");
                    Person newPerson = new Person(firstName, lastName);
                    Employee newEmployee = new Employee(employeeSSN);
                    MyConsole.PrintL($"\nYou have entered a new Employee: ");
                    MyConsole.PrintL($"Name: {newPerson.ToString()}");
                    MyConsole.PrintL($"Customer number: {newEmployee.ToString()}");
                }
                choice = MyConsole.PromptStrInRange("\nContinue? (y/n): ", "y", "n");
            }
            MyConsole.PrintL("You have been managed! Have a day!");
        }
    }
}
