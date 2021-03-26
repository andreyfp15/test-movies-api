using System.Collections.Generic;
using System.Linq;
using test_movies_api.Models;

namespace test_movies_api.Repository
{
    public class MovieRatingRepository
    {
        private readonly AppDbContext _context;

        public MovieRatingRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<MovieRating> Get()
        {
            return _context.MovieLevels.ToList();
        }

        public MovieRating Get(int idMovie)
        {
            return _context.MovieLevels.Where(b => b.idMovie == idMovie).FirstOrDefault();
        }

        public void Save(MovieRating movieRating)
        {
            _context.MovieLevels.Add(movieRating);
            _context.SaveChanges();
        }

        public void Update(MovieRating movieRating)
        {
            var ratingUpdate = _context.MovieLevels.ToList().Find(i => i.id == movieRating.id);

            if (ratingUpdate == null)
                return;

            ratingUpdate.idMovie = movieRating.idMovie;
            ratingUpdate.lvlCast = movieRating.lvlCast;
            ratingUpdate.lvlPhotography = movieRating.lvlPhotography;
            ratingUpdate.lvlScript = movieRating.lvlScript;
            ratingUpdate.lvlSpecialEffects = movieRating.lvlSpecialEffects;

            _context.SaveChanges();
        }
    }
}
