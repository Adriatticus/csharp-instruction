namespace csharp_project_3_1_temperature_converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Don't worry! It's not 150 degrees ferenheigt!\n");

            Console.WriteLine("Welcome to the Temperature Converter\n");

            string choice = "y";
            while (choice == "y" || choice == "Y")
            {
                Console.Write("\nEnter degrees in ferenheight: ");
                double tempF = Convert.ToDouble(Console.ReadLine());
                double conversion = (tempF - 32) * 5 / 9;
                Console.WriteLine("Degrees in Celcius: "+conversion);

                Console.Write("\nContinue? ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Stay cool!");



        }
    }
}
