using System;

namespace test_movies_api.Models
{
    public class Movie
    {
        public int id { get; set; }
        public bool adult { get; set; }
        public string backdrop_path { get; set; }
        public int[] genre_ids { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public decimal popularity { get; set; }
        public string poster_path { get; set; }
        public string release_date { get; set; }
        public string title { get; set; }
        public bool video { get; set; }
        public string vote_average { get; set; }
        public string vote_count { get; set; }

        private MovieRating _rating;
        public MovieRating rating
        {
            get
            {
                if (_rating == null)
                    _rating = new MovieRating();
                return _rating;
            }
            set { _rating = value; }
        }
    }
}
