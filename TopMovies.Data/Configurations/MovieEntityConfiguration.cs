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
	public class MovieEntityConfiguration : IEntityTypeConfiguration<Movie>
	{
		public void Configure(EntityTypeBuilder<Movie> builder)
		{
			throw new NotImplementedException();
		}

		private Movie[] SeedMovies()
		{
			throw new NotImplementedException();

			var genres = new HashSet<Genre>();

			Genre genre;

			genre = new Genre()
			{
				Id = 5
			};

			genres.Add(genre);

			var movies = new HashSet<Movie>();

			Movie movie;

			movie = new Movie()
			{
				Name = "The Shawshank Redemption",
				Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
				ReleaseDate = 1994,
				Genres = genres,

				

			};
		}
	}
}
