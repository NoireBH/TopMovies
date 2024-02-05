using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopMovies.Data.Models;
namespace TopMovies.Data.Configurations
{
	public class ActorMovieEntityConfiguration : IEntityTypeConfiguration<ActorsMovies>
	{
		public void Configure(EntityTypeBuilder<ActorsMovies> builder)
		{
			throw new NotImplementedException();
		}

		private void SeedActorMovies()
		{
			var actorMovies = new HashSet<ActorsMovies>();

			ActorsMovies actorMovie;

			actorMovie = new ActorsMovies()
			{
				
			};
		}
	}
}
