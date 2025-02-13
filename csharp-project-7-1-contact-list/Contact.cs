using System.Diagnostics.Contracts;

namespace csharp_project_7_1_contact_list
{
    internal class Contact
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Phone;

        public Contact()
        {

        }

        public Contact(string FirstName, string LastName, string Email, string Phone)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
        }

        public string GetFirstName()
        {
            return this.FirstName;
        }
        public void SetFirstName(string FirstName)
        {
            this.FirstName = FirstName;
        }
        public string GetLastName()
        {
            return this.LastName;
        }
        public void SetLastName(string LastName)
        {
            this.LastName = LastName;
        }
        public string GetEmail()
        {
            return this.Email;
        }
        public void SetEmail(string Email)
        {
            this.Email = Email; 
        }
        public string GetPhone()
        {
            return this.Phone;
        }
        public void SetPhone(string Phone)
        {
            this.Phone = Phone;
        }
        public void DisplayContact()
        {
            Console.WriteLine("\n\n--------------------------------------------");
            Console.WriteLine("---- Current Contact -----------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Name:\t\t{this.FirstName} {this.LastName}");
            Console.WriteLine($"Email Address:\t{this.Email}");
            Console.WriteLine($"Phone Number:\t{this.Phone}");
            Console.WriteLine("--------------------------------------------\n");
        }


    }
}
