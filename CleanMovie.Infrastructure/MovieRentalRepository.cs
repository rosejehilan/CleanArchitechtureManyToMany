using CleanMovie.Application.MovieRentals;
using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Infrastructure
{
    public class MovieRentalRepository : IMovieRentalRepository
    {
        private readonly MovieDbContext _movieDbContext;
        public MovieRentalRepository(MovieDbContext movieDbContext)
        {
            _movieDbContext = movieDbContext;  
        }
        public MovieRental CreateMovieRental(MovieRental movieRental)
        {
            _movieDbContext.MovieRentals.Add(movieRental);
            _movieDbContext.SaveChanges();

            return movieRental;
        }

        public List<MovieRental> GetAllMovieRentals()
        {
            return _movieDbContext.MovieRentals.ToList();
        }
    }
}
