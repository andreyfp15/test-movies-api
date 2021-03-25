using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Linq;
using System.Net.Http;
using test_movies_api.Models;
using test_movies_api.Repository;

namespace test_movies_api.Controllers
{
    [Route("v1/testmovies/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private const string KEY_TMDB = "3144d8976fc4e1e1fc1d45eafea01d87";
        private const string LANG = "en-US";
        private const bool INCLUDE_ADULT = false;

        [HttpGet("{page}/{query}")]
        public ReturnApi Get([FromServices] MovieRatingRepository movieRatingRep, int page, string query)
        {
            if (page == 0 || string.IsNullOrWhiteSpace(query))
                return new ReturnApi();

            var lstMovieRating = movieRatingRep.Get();
            var returnApi = GetTMDB(page, query);

            foreach (var movie in returnApi.results.Where(i => lstMovieRating.Any(j => j.idMovie == i.id)))
                movie.rating = lstMovieRating.Find(i => i.idMovie == movie.id);

            return returnApi;
        }

        public ReturnApi GetTMDB(int page, string query)
        {
            var uri = string.Format(@"https://api.themoviedb.org/3/search/movie?api_key={0}&language={1}&query={2}&page={3}&include_adult={4}", KEY_TMDB, LANG, query, page, INCLUDE_ADULT);

            var httpreq = new HttpClient();
            var response = httpreq.GetAsync(uri).Result;

            if (response.IsSuccessStatusCode)
                return JsonConvert.DeserializeObject<ReturnApi>(response.Content.ReadAsStringAsync().Result);

            return new ReturnApi();
        }
    }
}
