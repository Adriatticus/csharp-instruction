namespace csharp_project_10_2_person_manager_demo.Model
{
    internal class Employee : Person
    {
        public string Ssn { get; set; }

        public Employee(string firstName, string lastName, string ssn) :
            base(firstName, lastName)
        {
            Ssn = ssn;
        }

        public override string ToString()
        {
            // ssn - xxx-xx-####
            string ssnMasked = "xxx-xx-" + Ssn.Substring(7);
            return $"{base.ToString()}SSN: {ssnMasked}";
        }















    }
}
