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
	public class MovieGenreEntityConfiguration : IEntityTypeConfiguration<MovieGenre>
	{
		public void Configure(EntityTypeBuilder<MovieGenre> builder)
		{
			throw new NotImplementedException();
		}

		private void SeedMovieGenres()
		{
			var movieGenres = new HashSet<MovieGenre>();

			MovieGenre movieGenre;

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				GenreId = 5
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				GenreId = 5
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				GenreId = 4
			};

			movieGenres.Add(movieGenre);movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				GenreId = 4
			};

			movieGenres.Add(movieGenre);
		}
	}
}
