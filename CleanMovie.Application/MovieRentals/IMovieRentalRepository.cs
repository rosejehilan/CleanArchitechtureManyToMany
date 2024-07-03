using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanMovie.Domain;

namespace CleanMovie.Application.MovieRentals
{
    public interface IMovieRentalRepository
    {
        List<MovieRental> GetAllMovieRentals();
        MovieRental CreateMovieRental(MovieRental movieRental);
    }
}
