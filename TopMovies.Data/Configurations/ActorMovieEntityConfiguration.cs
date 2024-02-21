using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopMovies.Data.Models;
namespace TopMovies.Data.Configurations
{
	public class ActorMovieEntityConfiguration : IEntityTypeConfiguration<ActorMovie>
	{
		public void Configure(EntityTypeBuilder<ActorMovie> builder)
		{
			throw new NotImplementedException();
		}

		private void SeedActorMovies()
		{
			var actorMovies = new HashSet<ActorMovie>();

			ActorMovie actorMovie;

			//actorMovie = new ActorMovie()
			//{
			//	ActorId
			//};
		}
	}
}
