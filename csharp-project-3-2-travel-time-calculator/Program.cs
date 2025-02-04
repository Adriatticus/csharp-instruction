namespace csharp_project_3_2_travel_time_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I hope you brought your flux capacitor to class today becuse we're doing time travel today!!");

            Console.WriteLine("\nWelcome to the Travel Time Calculator");

            Console.Write("\nEnter miles: ");
            double distanceM = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter miles per hour: ");
            double speedMph = Convert.ToDouble(Console.ReadLine());
            // time = distance / speed
            double travelT = distanceM / speedMph;
            int hours = Convert.ToInt32(travelT);
            Console.WriteLine("\nEstimated travel time\n--------------------------------\n"+travelT);

        }
    }
}
