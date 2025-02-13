namespace csharp_project_10_2_person_manager
{
    public class Customer : Person
    {
        public string CustomerNbr { get; set; }


        public Customer()
        {

        }

        public Customer(string customerNbr)
        {
            CustomerNbr = customerNbr;
        }

        public string ToString()
        {
            return CustomerNbr;
        }
    }
}
