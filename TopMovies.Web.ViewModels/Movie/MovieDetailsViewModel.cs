using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;

namespace TopMovies.Web.ViewModels.Movie
{
    public class MovieDetailsViewModel
    {
        public MovieDetailsViewModel()
        {
            UserReviews = new HashSet<UserReview>();
            ActorsMovies = new HashSet<ActorMovie>();
            MovieGenres = new HashSet<MovieGenre>();
            MovieMovieCharacters = new HashSet<MovieMovieCharacter>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int ReleaseDateYear { get; set; }

        public double Rating { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        public virtual ICollection<MovieGenre> MovieGenres { get; set; }

        public virtual IEnumerable<UserReview> UserReviews { get; set; }

        public virtual ICollection<ActorMovie> ActorsMovies { get; set; }

        public virtual ICollection<MovieMovieCharacter> MovieMovieCharacters { get; set; }
    }
}
