using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.MovieRentals
{
    public interface IMovieRentalService
    {
        List<MovieRental> GetAllMovies();

        MovieRental CreateMovie(MovieRental movie);
    }
}
