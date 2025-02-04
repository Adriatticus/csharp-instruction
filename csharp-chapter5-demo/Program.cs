using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace cshartp_chapter5_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chapter 5 Demos");

            // p. 139 relational operators

            int a = 5;
            int b = 7;
            Console.WriteLine(a == b);

            String name1 = "Bob";
            String name2 = "bob";
            Console.WriteLine(name1 == name2);

            // p. 141 Logical operators
            // is sky blue and is temp above 74?

            int temp = 76; // both conditions must be true if this value changed it doesn't execute
            String skyColor = "blue";

            if (skyColor == "blue" && temp > 74)
            {
                Console.WriteLine("blue and above 74");
            }

            // p143 nested if - traffic light
            // simple r, y, g
            // yellow light rules:
            // -- dist < 20 yeards
            // -- dist >=20 <30, speed up
            // -- dist >=30, slow down

            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("light color? (r,y,g: ");
                string lightColor = Console.ReadLine();
                if (lightColor == "r")
                {
                    Console.WriteLine("Stop!");
                }
                else if (lightColor == "y")
                {
                    Console.Write("distnace to light (yards)? ");
                    int dist = Convert.ToInt32(Console.ReadLine());
                    string msg = "";
                    if (dist < 20)
                    {
                        msg = "Go!";
                    }
                    else if (dist < 30)
                    {
                        msg = "Hurry! GO!";
                    }
                    else
                    {
                        msg = "slow down";
                    }
                    Console.WriteLine(msg);
                }
                else if (lightColor == "g")
                {
                    Console.WriteLine("Go!");
                }
                Console.Write("continue: ");
                choice = Console.ReadLine();
            }

            // switch statement
            // CRUD Operations

            Console.WriteLine("Movie table - which action to perform?");
            string action = "";
            while (action != "exit")
            {
                Console.WriteLine("Menue:");
                Console.WriteLine("===========");
                Console.WriteLine("Get : Get All");
                Console.WriteLine("GID : Get Movie By ID");
                Console.WriteLine("ADD : Add Movie");
                Console.WriteLine("Upd : Update Movie");
                Console.WriteLine("Del : Delete Movie");
                Console.WriteLine("Exit : Exit");
                Console.Write("Action: ");
                action = Console.ReadLine().ToLower;

                switch (action)
                {
                    case "get":
                        Console.WriteLine("Get was selected");
                        break;

                    case "gid":
                        Console.WriteLine("Get was selected");
                        break;

                    case "add":
                        Console.WriteLine("Get was selected");
                        break;

                    case "upd":
                        Console.WriteLine("Get was selected");
                        break;

                    case "del":
                        Console.WriteLine("Get was selected");
                        break;

                    case "exit":
                        Console.WriteLine("Get was selected");
                        break;

                    default:
                        Console.WriteLine("Invalid selection - " + action);
                        break;
                }

            }

            // p. 147 case w/ arrow operators
            // customer type: discountPct
            // "R" - 10%
            // "C" - 20%
            // else - 0%

            string custType = "R";
            decimal discPct = 0.0m;

            discPct = custType switch
            {
                "R" => .1m,
                "C" => .2m,
                _ => .0m
            };
            Console.WriteLine("disctPct = " + discPct);

            // p. 151 conditional expression / ternary operator
            // day of week: weekday/weekend conversion
            // day is 1 - 5: weekday, 6 or 7: weekend

            int dow = 4;
            //string msg1 = "";
            //if (dow <= 5)
            //{
            //    msg1 = "weekday";
            //}
            //else
            //{
            //    msg1 = "weekend";
            //}

            // as conditional expr

            string msg1 = (dow <= 5) ? "weekday" : "weekend";

            Console.WriteLine(msg1);



        }
    }
}
