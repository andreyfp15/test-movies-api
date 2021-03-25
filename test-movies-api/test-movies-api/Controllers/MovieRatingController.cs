using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using test_movies_api.Models;
using test_movies_api.Repository;

namespace test_movies_api.Controllers
{
    [Route("v1/testmovies/[controller]")]
    [ApiController]
    public class MovieRatingController : ControllerBase
    {
        [HttpGet]
        public List<MovieRating> Get([FromServices] MovieRatingRepository movieRatingRep)
        {
            return movieRatingRep.Get();
        }

        [HttpPut]
        public IActionResult PutMovieRating([FromServices] MovieRatingRepository movieRatingRep, MovieRating movieRating)
        {
            var lstMovieRating = movieRatingRep.Get();

            if (lstMovieRating.Any(i => i.id == movieRating.id))
            {
                movieRatingRep.Update(movieRating);
                return Ok();
            }

            movieRatingRep.Save(movieRating);
            return Ok();
        }
    }
}
