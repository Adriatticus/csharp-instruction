namespace csharp_project_10_2_person_manager
{
    internal class Employee : Person
    {
        public string EmployeeSSN { get; set; }


        public Employee()
        {

        }

        public Employee(string employeeSSN)
        {
            EmployeeSSN = employeeSSN;
        }

        public string ToString()
        {
            return EmployeeSSN;
        }
    }
}

