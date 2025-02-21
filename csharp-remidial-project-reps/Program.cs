using System.Xml.Serialization;
using ConsoleLibrary;

namespace csharp_remidial_project_reps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintL("Welcome to my program where I get ripped doing reps\n");




            int Command = 1988;
            while (Command != 0)
            {
                DisplayFlexMenue();
                Command = MyConsole.PromptInt("\t\tCommand: ");
                switch (Command)
                {
                    case 1:
                        GradeConverter();
                        break;

                    case 0:
                        break;

                            
                }

            }
            MyConsole.PrintL("\nFeeling any faster?!?!?! Hope so");
        }

        private static void GradeConverter()
        {
            string choice = "y";
            MyConsole.PrintL("\nWelcome to the Letter Grade Converter\n");
            while (choice.ToLower() == "y")
            {
                const int MIN = 00;
                const int MAX = 100;
                int numGrade = MyConsole.PromptIntInRange("\nEnter numerical grade: ", MIN, MAX);
                if (numGrade > 87 && numGrade < 101)
                {
                    MyConsole.PrintL("Letter Grade: A"); //if // numerical grade is 90 Lettergrade A
                }
                else if (numGrade > 79 && numGrade < 88)
                {
                    MyConsole.PrintL("Letter Grade: B");
                }
                else if (numGrade > 66 && numGrade < 80)
                {
                    MyConsole.PrintL("Letter Grade: C");
                }
                else if (numGrade > 59 && numGrade < 88)
                {
                    MyConsole.PrintL("Letter Grade: D");
                }
                else
                {
                    MyConsole.PrintL("Letter Grade: F");
                }
                choice = MyConsole.PromptStrInRange("\nContinue? (y/n): ", "y", "n");
            }
        }

        public static void DisplayFlexMenue()
        {
        MyConsole.PrintL("\n====== How will you bulk up? Choose a program! ======");
        MyConsole.PrintL("\n\t\t1) Grade Converter");
        MyConsole.PrintL("\t\t2) Interest Calculator");
        MyConsole.PrintL("\t\t3) Tip Calculator");
        MyConsole.PrintL("\t\t4) Dice Roller");
        MyConsole.PrintL("\t\t5) Contact Manager");
        MyConsole.PrintL("\t\t6) Counterly List Manager");
        MyConsole.PrintL("\t\t7) Student Scores");
        MyConsole.PrintL("\t\t0) Exit\n");
        }
    }
}


    

