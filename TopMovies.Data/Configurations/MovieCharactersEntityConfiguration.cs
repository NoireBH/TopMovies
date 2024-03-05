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
	public class MovieCharactersEntityConfiguration : IEntityTypeConfiguration<MovieCharacter>
	{
		public void Configure(EntityTypeBuilder<MovieCharacter> builder)
		{
			throw new NotImplementedException();
		}

		private void SeedMovieCharacters()
		{
			var movieCharacters = new HashSet<MovieCharacter>();

			MovieCharacter movieCharacter;

			movieCharacter = new MovieCharacter()
			{
				Id = 1,
				Name = "Test",
				Description = "Test",
				ImageUrl = ""
			};

			movieCharacters.Add(movieCharacter);
		}
	}
}
