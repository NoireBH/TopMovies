using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Web.ViewModels.MovieCharacters
{
	public class MovieCharacterViewModel
	{
		public int CharacterId { get; set; }

		public string CharacterName { get; set; } = null!;

		public string CharacterImageUrl { get; set; } = null!;
	}
}
