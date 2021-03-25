using System.ComponentModel.DataAnnotations.Schema;

namespace test_movies_api.Models
{
    public class MovieRating
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int idMovie { get; set; }
        public int lvlScript { get; set; }
        public int lvlPhotography { get; set; }
        public int lvlSpecialEffects { get; set; }
        public int lvlCast { get; set; }
    }
}
