using TopMovies.Services.Mapping;
using TopMovies.Data.Models;
using AutoMapper;
using TopMovies.Web.ViewModels.MoviesGenres;
using TopMovies.Web.ViewModels.UserReviews;
using TopMovies.Web.ViewModels.ActorsMovies;
using TopMovies.Web.ViewModels.MoviesMovieCharacters;

namespace TopMovies.Web.ViewModels.Movies
{
    public class MovieDetailsViewModel : IMapFrom<Movie>, IHaveCustomMappings
    {
        public MovieDetailsViewModel()
        {
            UserReviews = new HashSet<UserReviewViewModel>();
            ActorsMovies = new HashSet<ActorMovieViewModel>();
            MovieGenres = new HashSet<MovieGenreViewModel>();
            MovieMovieCharacters = new HashSet<MovieMovieCharacterViewModel>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int ReleaseDateYear { get; set; }

        public double Rating { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string TrailerUrl { get; set; } = null!;

		public virtual ICollection<MovieGenreViewModel> MovieGenres { get; set; }

        public virtual IEnumerable<UserReviewViewModel> UserReviews { get; set; }

        public virtual ICollection<ActorMovieViewModel> ActorsMovies { get; set; }

        public virtual ICollection<MovieMovieCharacterViewModel> MovieMovieCharacters { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Movie, MovieDetailsViewModel>()
                .ForMember(m => m.ReleaseDateYear, cfg => cfg
                    .MapFrom(m => m.ReleaseDate.Year));
        }
    }
}
