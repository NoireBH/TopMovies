using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;
using TopMovies.Data.Models.Enums;

namespace TopMovies.Data.Configurations
{
	public class MovieEntityConfiguration : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			throw new NotImplementedException();
		}

		private Movie[] SeedMovies()
		{
			throw new NotImplementedException();

			var actors = new List<Actor>();

			Actor actor;

			actor = new Actor()
			{
				Id = 1,
				Name = "Tim Robbins",
				Description = "Born in West Covina, California, but raised in New York City, Tim Robbins is the son of former The Highwaymen singer Gil Robbins and actress Mary Robbins (née Bledsoe). Robbins studied drama at UCLA, where he graduated with honors in 1981. That same year, he formed the Actors' Gang theater group, an experimental ensemble that expressed radical political observations through the European avant-garde form of theater. He started film work in television movies in 1983, but hit the big time in 1988 with his portrayal of dimwitted fastball pitcher \"Nuke\" Laloosh in Bull Durham (1988). Tall with baby-faced looks, he has the ability to play naive and obtuse (Cadillac Man (1990) and The Hudsucker Proxy (1994)) or slick and shrewd (The Player (1992) and Bob Roberts (1992)).",
				ImagePath = "~Images/jPsLqiYGSofU4s6BjrxnefMfabb",
				YearBorn = new DateTime(1937, 6, 1)

			};

			var movies = new HashSet<Movie>();

			Movie movie;

			movie = new Movie()
			{
				Name = "The Shawshank Redemption",
				Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
				ReleaseDate = 1994,
				Genres = new HashSet<Genre> {Genre.Drama},
				Actors = actors
				

			};
		}
	}
}
