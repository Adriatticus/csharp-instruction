namespace csharp_chapter12_demos
{
    internal class Program
    {
        static List<Movie> Movies = new List<Movie>();
        static void Main(string[] args)
        {
            Console.WriteLine("We're eating layers of cake brother!");

            //Movie newMovie= new Movie();
            newMovie.Id = 1;
            newMovie.Title = "Jurassic Park";
            newMovie.Year = 2025;
            newMovie.Rating = "PG-13";
            newMovie.Director = "Gareth Edwards";
            Movies.Add(newMovie);
            
            PrintL($"newMovie title = {newMovie.Title}");
            PrintL(newMovie.ToString());

            string choice = "y";
            while (choice == "y")
            {
            // capture input for properties of a movie
            int id = PromptInt("Movie ID: ");
            string title = PromptString("Movie Title: ");
            int year = PromptInt("Year: ");
            string ageRating = PromptString("Age Rating: ");
            string director = PromptString("Director: ");
            Movie newMovie = new Movie(id, title, year, ageRating,director);
            //Movies.Add(newMovie);
            // store this movie and capture a new one
                choice = PromptString("Add another movie? (y/n): ");
            }

           // Movie newMovie = new Movie();
            // p. 376 read encapsulation - read 377 - super understand class



            //Movie newMovie1 = new Movie(id, title, year, ageRating, director);

            // repeat until user is done entering movies
            // display all movies


            Console.WriteLine("Cake has been destroyed");
        }
        static int PromptInt(string prompt)
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

        static string PromptString(string prompt)
        {
            Print(prompt);
            return Console.ReadLine();
        }

        static void Print(string msg)
        {
            Console.Write(msg);
        }

        static void PrintL(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
