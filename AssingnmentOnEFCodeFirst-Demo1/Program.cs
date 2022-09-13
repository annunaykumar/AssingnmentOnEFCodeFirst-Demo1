using AssingnmentOnEFCodeFirst_Demo1.Entities;
using AssingnmentOnEFCodeFirst_Demo1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingnmentOnEFCodeFirst_Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieRepository movieRepository = new MovieRepository();

            do
            {
                Console.WriteLine("1.AddMovie\n2.GetAllMovie\n3.GetMovieByMovieId\n4.DeleteMovie\n5.EditMovie");
                Console.WriteLine("Enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        {
                            Movie movie = new Movie();
                            Console.WriteLine("Enter MovieId");
                            movie.MovieId =int.Parse(Console.ReadLine());
                            movie.MovieName = "Hulk";
                            movie.Actor = "Eric Bana";
                            movie.ReleaseDate = new DateTime(2012, 05, 09);
                            movie.Producer = " Lary Franco";
                            movieRepository.AddMovie( movie);
                        }
                        break;
                    case 2:
                        {
                            List<Movie> movies = new MovieRepository().GetAllMovie();
                            foreach (var movie in movies)
                                Console.WriteLine($"MovieID:{movie.MovieId} MovieName:{movie.MovieName} Actor:{movie.Actor} releaseDate:{movie.ReleaseDate} producer:{movie.Producer}");

                        }
                        break;
                    case 3:
                        {
                          
                            Console.WriteLine("EnteMovieId");
                            int id =int.Parse(Console.ReadLine());
                            Movie movies= movieRepository.GetMovie(id);
                            Console.WriteLine($"MovieID:{movies.MovieId} MovieName:{movies.MovieName} Actor:{movies.Actor} releaseDate:{movies.ReleaseDate} producer:{movies.Producer}");
                            
                        }
                       
                        break;
                    case 4:
                        {
                            Console.WriteLine("Enter MovieId");
                            int id = int.Parse(Console.ReadLine());
                            movieRepository.DeleteMovie(id);
                        }
                        
                        break;
                    case 5:
                        {
                            Console.WriteLine("Enter MovieId");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter MovieName");
                            string MovieName = (Console.ReadLine());
                            movieRepository.EditMovie(id, MovieName);

                        }
                        break;
                    

                }
            } while (true);
        }
    }
}
