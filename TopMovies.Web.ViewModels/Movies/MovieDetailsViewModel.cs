using TopMovies.Services.Mapping;
using TopMovies.Data.Models;
using AutoMapper;
using TopMovies.Web.ViewModels.MoviesGenres;
using TopMovies.Web.ViewModels.UserReviews;
using TopMovies.Web.ViewModels.MoviesMovieCharacters;
using TopMovies.Web.ViewModels.Actors;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieDetailsViewModel : IMapFrom<Movie>, IHaveCustomMappings
    {
        public MovieDetailsViewModel()
        {
            UserReviews = new HashSet<UserReviewViewModel>();
			ActorsAndCharacters = new HashSet<MovieActorsAndCharactersViewModel>();
            MovieGenres = new HashSet<MovieGenreViewModel>();
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

        public virtual IEnumerable<MovieActorsAndCharactersViewModel> ActorsAndCharacters { get; set; }

        public void CreateMappings(IProfileExpression configuration)
        {
            configuration.CreateMap<Movie, MovieDetailsViewModel>()
                .ForMember(m => m.ReleaseDateYear, cfg => cfg
                    .MapFrom(m => m.ReleaseDate.Year));
        }
    }
}
