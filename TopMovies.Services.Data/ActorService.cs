using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Actors;

namespace TopMovies.Services.Data
{
	public class ActorService : IActorService
	{
		private readonly TopMoviesDbContext context;

		public ActorService(TopMoviesDbContext context)
		{
			this.context = context;
		}

		public async Task<bool> ExistsByIdAsync(int id)
		{
			return await context.Actors.AnyAsync(m => m.Id == id);
		}

		public async Task<ActorDetailsViewModel> GetActorByIdAsync(int id)
		{
			var actor = await context.Actors
				.Where(a => a.Id == id)
				.To<ActorDetailsViewModel>()
				.FirstOrDefaultAsync();

			return actor!;
		}

		public async Task<ActorViewModel[]> GetAllMovieActorsByMovieIdAsync(string id)
		{
			var actors = await context.ActorMovies
				.Where((x => x.MovieId.ToString() == id))
				.Select(am => new ActorViewModel
				{
					ActorId = am.ActorId,
					ActorName = am.Actor.Name,
					ActorImageUrl = am.Actor.ImageUrl

				})
				.ToArrayAsync();

			return actors;
		}

		public async Task<ActorMoviesViewModel[]> GetAllOfTheActorsMoviesByIdAsync(int id)
		{
			var actorsMovies = await context.ActorMovies
				.Where(a => a.ActorId == id)
				.To<ActorMoviesViewModel>()
				.ToArrayAsync();

			return actorsMovies;
		}
	}
}
