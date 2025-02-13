namespace csharp_project_10_2_person_manager_demo.Model
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string ToString()
        {
            return $"Name: {FirstName} {LastName}\n";
        }
    }
}
