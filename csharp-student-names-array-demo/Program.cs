using ConsoleLibrary;

namespace csharp_student_names_array_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintL("Hello, World!\n");

                            // prompt user for # of students
            int nbrStudents = MyConsole.PromptInt("Number of students: ");
            string[] studentArray = new string[nbrStudents];
                            // for loop - loop through the studentArray
            for (int i = 0; i < nbrStudents; i++)
                            // - for each position in the array:
            {
                            //  - prompt name
                string name = MyConsole.PromptString($"Student Name [{i}]: ");
                            //  - add name to studentArray
                studentArray[i] = name;
            }

            // print the array on one line - one way
            //string names = "";
            //foreach (string name in studentArray)
            //{
            //    names += name + "|";
            //    // // this += is like overwriting names = names + name
            //}
            //MyConsole.PrintL(names);

            //// way 2 with for each
            //foreach (string n in studentArray)
            //{
            //    MyConsole.Print(n + "|");
            //}
            //MyConsole.PrintL("");

            // the lambda way
            Array.Sort(studentArray);
            Array.ForEach(studentArray, student => MyConsole.Print(student + "|"));
            MyConsole.PrintL("");
                            





            MyConsole.PrintL("\nSee ya!");
        }
    }
}
