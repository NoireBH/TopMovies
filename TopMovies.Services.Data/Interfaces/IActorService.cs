using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Web.ViewModels.ActorsMovies;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IActorService
	{
		Task<ActorMovieViewModel[]> GetAllMovieActorsByMovieIdAsync(string id);
	}
}
