using ConsoleLibrary;
using csharp_project_10_2_person_manager_demo.Model;

namespace csharp_project_10_2_person_manager_demo.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, People! Prepare to be managed!");

            string choice = "y";
            while (choice == "y")
            {

                string personType = MyConsole.PromptStrInRange("\nCreate customer employee (c/e): ", "c", "e" );
                string firstName = MyConsole.PromptString("\nFirst name: ");
                string lastName = MyConsole.PromptString("Last name: ");
                Person p;
                if (personType == "c")
                {
                    string customerNumber = MyConsole.PromptString("Customer number: ");
                    Customer c = new Customer(firstName, lastName, customerNumber);
                    p = c;
                }
                else
                {
                    string ssn = MyConsole.PromptString("SSN: ");
                    Employee e = new Employee(firstName, lastName, ssn);
                    p = e;
                }
                MyConsole.Print("");
                MyConsole.PrintL("\nYou entered a new "+p.GetType().Name+":\n===========================");
                MyConsole.PrintL(p.ToString());




                choice = MyConsole.PromptStrInRange("\nContinue? (y/n): ", "y", "n");
            }
            
            MyConsole.PrintL("You have been managed!");
        }
    }
}
