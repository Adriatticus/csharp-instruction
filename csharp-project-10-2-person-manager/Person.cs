namespace csharp_project_10_2_person_manager
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }   

        public string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
