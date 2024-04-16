using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Data.Models;
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

		public async Task AddActorAndRoleToMovieAsync(MovieActorAndRoleAddOrEditFormModel model, string movieId)
		{
			var actor = new Actor()
			{
				Name = model.ActorName,
				Description = model.ActorDescription,
				ImageUrl = model.ActorImageUrl,
				DateOfBirth = model.ActorDateOfBirth
			};

			await context.Actors.AddAsync(actor);
			await context.SaveChangesAsync();

			var actorMovie = new ActorMovie()
			{
				Actor = actor,
				MovieId = new Guid(movieId)
			};

			await context.ActorMovies.AddAsync(actorMovie);
			await context.SaveChangesAsync();

			var movieCharacter = new MovieCharacter()
			{
				Name = model.MovieCharacterName,
				ImageUrl = model.MovieCharacterImageUrl,
				Age = model.MovieCharacterAge,
				ActorId = actor.Id,
				MovieId = new Guid(movieId)
			};

			await context.MovieCharacters.AddAsync(movieCharacter);

			await context.SaveChangesAsync();
		}

		public async Task DeleteActorAndRoleFromMovieByTheirIdsAsync(string movieId, int actorId)
		{

			var movieCharacter = await context.MovieCharacters
				.Where(mc => mc.MovieId.ToString() == movieId && mc.ActorId == actorId)
				.FirstOrDefaultAsync();

			context.MovieCharacters.Remove(movieCharacter!);

			var actorMovie = await context.ActorMovies
				.Where(mc => mc.MovieId.ToString() == movieId && mc.ActorId == actorId)
				.FirstOrDefaultAsync();

			context.ActorMovies.Remove(actorMovie!);

			await context.SaveChangesAsync();
		}
		public async Task<bool> ExistsByIdAsync(int id)
		{
			return await context.Actors.AnyAsync(m => m.Id == id);
		}

		public async Task<bool> ExistsByActorAndMovieCharacterNames(string actorName, string movieCharacterName)
		{
			return await context.MovieCharacters.AnyAsync(mc => mc.Name == movieCharacterName && mc.Actor.Name == actorName);
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

		public async Task<bool> ExistsByActorAndMovieIdAsync(int actorId, string movieId)
		{
			return await context.ActorMovies.AnyAsync(am => am.MovieId.ToString() == movieId && am.ActorId == actorId);
		}

		public async Task EditActorAndRoleFromMovieByTheirIdsAsync(MovieActorAndRoleAddOrEditFormModel model, int actorId)
		{
			var actor = await context.Actors
				.Where(a => a.Id == actorId)
				.FirstOrDefaultAsync();

			actor!.Name = model.ActorName;
			actor.Description = model.ActorDescription;
			actor.ImageUrl = model.ActorImageUrl;
			actor.DateOfBirth = model.ActorDateOfBirth;

			var movieCharacter = await context.MovieCharacters
				.Where(mc => mc.MovieId.ToString() == model.MovieId && mc.ActorId == actorId)
				.FirstOrDefaultAsync();

			movieCharacter!.Age = model.MovieCharacterAge;
			movieCharacter.ImageUrl = model.MovieCharacterImageUrl;

			await context.SaveChangesAsync();			
		}

		public async Task<MovieActorAndRoleAddOrEditFormModel> GetActorAndTheirRoleByMovieIdAsync(string movieId, int actorId)
		{
			var actorAndRole = await context.MovieCharacters
				.Where(mc => mc.MovieId.ToString() == movieId && mc.ActorId == actorId)
				.To<MovieActorAndRoleAddOrEditFormModel>()
				.FirstOrDefaultAsync();

			return actorAndRole!;
		}
	}
}
