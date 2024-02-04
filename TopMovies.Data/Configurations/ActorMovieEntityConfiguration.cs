using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;

namespace TopMovies.Data.Configurations
{
	public class ActorMovieEntityConfiguration : IEntityTypeConfiguration<ActorMovie>
	{
		public void Configure(EntityTypeBuilder<ActorMovie> builder)
		{
			throw new NotImplementedException();
		}

		private ActorMovie[] SeedActorMovies()
		{
			var actorMovies = new HashSet<ActorMovie>();

			ActorMovie actorMovie;

			actorMovie = new ActorMovie()
			{
				
			};
		}
	}
}
