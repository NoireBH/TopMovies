using TopMovies.Services.Mapping;
using TopMovies.Data.Models;
using AutoMapper;
using TopMovies.Web.ViewModels.MoviesGenres;
using TopMovies.Web.ViewModels.UserReviews;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels.MovieCharacters;

namespace TopMovies.Web.ViewModels.Movies
{
    public class MovieDetailsViewModel : IMapFrom<Movie>
    {
        public MovieDetailsViewModel()
        {
            UserReviews = new HashSet<UserReviewViewModel>();
            Actors = new HashSet<ActorViewModel>();
            Characters = new HashSet<MovieCharacterViewModel>();
            MovieGenres = new HashSet<MovieGenreViewModel>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime ReleaseDate { get; set; }

        public double Rating { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string TrailerUrl { get; set; } = null!;

        public virtual ICollection<MovieGenreViewModel> MovieGenres { get; set; }

        public virtual IEnumerable<UserReviewViewModel> UserReviews { get; set; }

        public virtual IEnumerable<ActorViewModel> Actors { get; set; }

        public virtual IEnumerable<MovieCharacterViewModel> Characters { get; set; }
    }
}
