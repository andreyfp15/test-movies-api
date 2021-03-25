using System.Collections.Generic;

namespace test_movies_api.Models
{
    public class ReturnApi
    {
        public int page { get; set; }
        public int total_pages { get; set; }
        public int total_results { get; set; }

        private List<Movie> _results;
        public List<Movie> results
        {
            get
            {
                if (_results == null)
                    _results = new List<Movie>();
                return _results;
            }
            set { _results = value; }
        }
    }
}
