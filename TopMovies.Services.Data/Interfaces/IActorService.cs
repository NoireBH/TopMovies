using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Web.ViewModels.ActorsMovies;
using TopMovies.Web.ViewModels.MoviesMovieCharacters;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IActorService
	{
		Task<ActorMovieViewModel[]> GetAllMovieActorsByMovieIdAsync(string id);

		Task<Dictionary<ActorMovieViewModel, MovieMovieCharacterViewModel>> GetActorsWithTheirCharactersByMovieIdAsync(string id);
	}
}
