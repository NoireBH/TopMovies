using System.ComponentModel.DataAnnotations;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.MoviesMovieCharacters
{
	public class MovieMovieCharacterViewModel : IMapFrom<MovieMovieCharacter>
    {
        public int MovieCharacterId { get; set; }

        public string MovieId { get; set; } = null!;

        public string Name { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;
    }
}
