namespace csharp_project_10_2_person_manager_demo.Model
{
    internal class Customer : Person
    {
        public string CustomerNumber { get; set; }

        public Customer(string firstName, string lastName, string customerNumber) :
        base(firstName, lastName)
        {
            CustomerNumber = customerNumber;
        }

        public override string ToString()
        {
            return $"{base.ToString()}Customer Number: {CustomerNumber}";
        }



















    }
}
