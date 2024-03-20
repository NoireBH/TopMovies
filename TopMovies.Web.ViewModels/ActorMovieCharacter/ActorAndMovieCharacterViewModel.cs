using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Web.ViewModels.ActorMovieCharacter
{
	public class ActorAndMovieCharacterViewModel
	{
		public IEnumerable<ActorAndMovieCharacterInfoViewModel> ActorsAndCharacters { get; set; } = null!;
	}
}
