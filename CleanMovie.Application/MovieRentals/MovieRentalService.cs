using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.MovieRentals
{
    public class MovieRentalService : IMovieRentalService
    {
        private readonly IMovieRentalRepository _movieRentalRepository;
        //Constructor Dependency Injection
        public MovieRentalService(IMovieRentalRepository movieRentalRepository)
        {
            _movieRentalRepository = movieRentalRepository;
        }
        public MovieRental CreateMovie(MovieRental movieRental)
        {
            _movieRentalRepository.CreateMovieRental(movieRental);
            return movieRental;
        }
        public List<MovieRental> GetAllMovies()
        {
            var movieRentals = _movieRentalRepository.GetAllMovieRentals();
            return movieRentals;
        }
    }
}
