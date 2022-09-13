using AssingnmentOnEFCodeFirst_Demo1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssingnmentOnEFCodeFirst_Demo1.Repositories
{
    internal class MovieRepository
    {
        public appDbContext db = new appDbContext();
        public void AddMovie(Movie movie)
        {
            db.Movies.Add(movie);
            db.SaveChanges();
        }
        public List<Movie> GetAllMovie()
        {
            return db.Movies.ToList();
        }
        public List<Movie> GetMovieByMovieId(int movieId)
        {
            return db.Movies.Where(m => m.MovieId == movieId).ToList();
        }
        public Movie GetMovie(int movieId)
        {
            return db.Movies.Find(movieId);
        }
        public void DeleteMovie(int movieId)
        {
            Movie movie = db.Movies.Find(movieId);
            db.Movies.Remove(movie);
            db.SaveChanges();
        }
        public void EditMovie(int movieId, string moviename) // salary is new salary
        {
            Movie movie = db.Movies.Find(movieId);
            movie.MovieName = moviename;
            db.SaveChanges();
        }
    }
}
