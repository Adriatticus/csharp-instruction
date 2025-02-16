using ConsoleLibrary;

namespace csharp_chapter17_demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Files!\n");

            string dir = @"C:\C#\Files\";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                MyConsole.PrintL("dir created!");
            }
            else
            {
                MyConsole.PrintL("dir already exists");
            }
            string path = dir + "names.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
                MyConsole.PrintL("file created");
            }
            else
            {
                MyConsole.PrintL("file already exists");
            }

            // write some names to our file...
            //StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            //writer.WriteLine("Adrian");
            //writer.WriteLine("Jim");
            //writer.WriteLine("Celina");
            //writer.WriteLine("Nick");
            //writer.WriteLine("Drew");
            //writer.Close();
            //MyConsole.PrintL("Writer done");

            MyConsole.PrintL("\n==== reading names.txt ====\n");
            StreamReader reader = new StreamReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));
            List<string> lines = new List<string>();
            while (reader.Peek() != -1)
            {
                string row = reader.ReadLine() ?? "";
                lines.Add(row);
            }
            reader.Close();

            foreach (string line in lines)
            {
                MyConsole.PrintL($"line = {line}");
            }


            MyConsole.PrintL("\nBye, Files!");
        }
    }
}
