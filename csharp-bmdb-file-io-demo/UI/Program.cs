using ConsoleLibrary;

namespace csharp_bmdb_file_io_demo.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintL("Hello dbdbdbs");

            //Movie m1 = new Movie(1, "Spaceballs", 1985, "PG", "Mel Brooks");
            //Movie m2 = new Movie(2, "Totally Awesome", 2025, "PG-13", "Sean Blessing");

            List<Movie> movies = new List<Movie>();
            //movies.Add(m1);
            //movies.Add(m2);
            //MovieDB.SaveMovies(movies);

            movies = MovieDB.GetMovies();
            foreach (Movie movie in movies)
            {
                MyConsole.PrintL(movie.ToString());
            }

        }
    }
}
