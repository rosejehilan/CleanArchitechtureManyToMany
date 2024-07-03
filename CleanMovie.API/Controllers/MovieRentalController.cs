using CleanMovie.Application;
using CleanMovie.Application.MovieRentals;
using CleanMovie.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanMovie.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieRentalController : Controller
    {
        private readonly IMovieRentalService _movieRentalService;
        public MovieRentalController(IMovieRentalService movieRentalService)
        {
            _movieRentalService = movieRentalService;
        }
        [HttpGet]
        public ActionResult<List<MovieRental>> Get()
        {
            var moviesRentalFromService = _movieRentalService.GetAllMovies();
            return Ok(moviesRentalFromService);
        }

        [HttpPost]
        public ActionResult<MovieRental> PostMovie(MovieRental movieRental)
        {
            var Movie = _movieRentalService.CreateMovie(movieRental);
            return Ok(movieRental);
        }


    }
}
