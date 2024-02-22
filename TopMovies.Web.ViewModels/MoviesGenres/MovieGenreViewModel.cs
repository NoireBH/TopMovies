using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.MoviesGenres
{
    public class MovieGenreViewModel : IMapFrom<MovieGenre>
    {
        public int GenreId { get; set; }

        public string GenreGenreName { get; set; } = null!;
    }
}
