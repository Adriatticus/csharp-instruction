using System.Xml.Serialization;

namespace csharp_project_3_2_travel_time_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, I hope you brought your flux capacitor to class today becuse we're doing time travel today!!");

            Console.WriteLine("\nWelcome to the Travel Time Calculator");

            string choice = "y";
            while (choice.ToLower() == "y")
            {
                Console.Write("\nEnter miles:\t\t");
                double distanceM = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter miles per hour:\t");
                double speedMph = Convert.ToDouble(Console.ReadLine());
                // time = distance / speed
                double travelT = distanceM / speedMph;
                double minutes = Math.Round((travelT % 1) * 60); // Math.Floor will round OOOOOOwalthe way down
                double minutesDec = (travelT % 1);
                double hours = (travelT - minutesDec);
                Console.WriteLine("\nEstimated travel time\n---------------------\n" + "Hours:\t\t" + hours +
                    "\nMinutes:\t" + minutes);
                //double minutes = (hours - travelT);
                //Console.WriteLine(minutes);

                Console.Write("\nContinue? ");
                choice = Console.ReadLine();
            }


        }
    }
}
