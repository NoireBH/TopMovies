using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.MoviesMovieCharacters
{
    public class MovieMovieCharacterViewModel : IMapFrom<MovieMovieCharacterViewModel>
    {
        public int MovieCharacterId { get; set; }

        public string Name { get; set; } = null!;

        [Required]
        public string ImagePath { get; set; } = null!;
    }
}
