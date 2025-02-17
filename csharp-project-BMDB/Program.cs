using System.Data;
using System.Net.Http.Headers;
using ConsoleLibrary;

namespace csharp_project_BMDB
{
    internal class Program
    {
        static List<Movie> movies = new List<Movie>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, movies! Prepare to be managed!\n");

            MyConsole.PrintL("Welcome to the Bootcamp Movie Database!\n");

            //string OWShieldDir = @"C:\C#\Files\";
            //if (!Directory.Exists(OWShieldDir))
            //{
            //    Directory.CreateDirectory(OWShieldDir);
            //    MyConsole.PrintL($"Directory: {OWShieldDir} has been created.");
            //}
            //else
            //{
            //    MyConsole.PrintL("Directory already exists");
            //}
            //string OWShieldPath = OWShieldDir + "Movies.txt";
            //if (!File.Exists(OWShieldPath))
            //{
            //    File.Create (OWShieldPath);
            //    MyConsole.PrintL($"File: {OWShieldPath} has been created.");
            //}
            //else
            //{
            //    MyConsole.PrintL("File already exists");
            //}

            movies = MovieDB.GetMovies();

            int command = 1988;
            while(command != 0)
            {
                DisplayMenu();
                command = MyConsole.PromptInt("Command: ");
                switch (command)
                {
                    case 0:
                        break;
                    case 1:
                        ListMovies();
                        break;
                    case 2:
                        GetMovie();
                        break;
                    case 3:
                        AddMovie();
                        break;
                    case 4:
                        DeleteMovie();
                        break;
                    default:
                        MyConsole.PrintL("Invalid Command. Try again.");
                            break;

                }
            }

            MyConsole.PrintL("\nMovies! You have been managed. Per management guidlines, have a productive day.");
        }

        private static void ListMovies()
        {
            MyConsole.PrintL("\n_________________Movie_Database_________________\n");
            foreach (Movie m in movies)
            {
                MyConsole.PrintL(m.ToString());
            }
            MyConsole.PrintL("");
        }

        private static void AddMovie()
        {
            MyConsole.PrintL("\n_________________Add_Movie_________________\n");
            string id = MyConsole.PromptString("Id:\t\t");
            string title = MyConsole.PromptString("Title:\t\t");
            int year = MyConsole.PromptInt("Year:\t\t");
            string rating = MyConsole.PromptString("Rating:\t\t");
            string director = MyConsole.PromptString("Director:\t");
            Movie m = new Movie(id, title, year, rating, director);
            movies.Add(m);
            MovieDB.SaveMovie(movies);
            MyConsole.PrintL("\nMovie added");
        }

        private static void DisplayMenu()
        {
            MyConsole.PrintL("\n1) List all movies.");
            MyConsole.PrintL("2) Get movie by ID.");
            MyConsole.PrintL("3) Add movie.");
            MyConsole.PrintL("4) Delete movie by ID.");
            MyConsole.PrintL("0) Exit.\n");
        }

        private static void DeleteMovie()
        {
            MyConsole.PrintL("\n_________________Delete_Movie_________________\n");
            string id = MyConsole.PromptString("Movid ID: ");
            foreach (Movie m in movies)
            {
                if (m.Id == id)
                {
                    movies.Remove(m);
                    MovieDB.SaveMovie(movies);
                    Console.WriteLine("\nMovie deleted");
                    break;
                }
            }
        }

        private static void GetMovie()
        {
            MyConsole.PrintL("\n_________________Movie_________________\n");
            string id = MyConsole.PromptString("Movie ID: ");
            foreach (Movie m in movies)
            {
                if (m.Id == id)
                {
                    MyConsole.PrintL(m.ToString());
                }
            }
        }
    }
}
