namespace csharp_grade_converter_class_thing
{
    internal class MyConsole
    {
        public static int PromptInt(string prompt)
        {
            int result = 0;
            bool success = false;
            while (!success)
            {
                Print(prompt);
                if (Int32.TryParse(Console.ReadLine(), out result))
                {
                    success = true;
                }
                else
                {
                    PrintL("Error - invalid int.");
                }
            }
            return result;

        }

        public static string PromptString(string prompt)
        {
            Print(prompt);
            return Console.ReadLine();
        }

        public static void Print(string msg)
        {
            Console.Write(msg);
        }

        public static void PrintL(string msg)
        {
            Console.WriteLine(msg);
        }
    }

}
