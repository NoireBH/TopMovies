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
				Name = "Andy Dufresne",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZTZlNGQ5MjAtZmE3OC00MWFlLWE2MWItYWY2ZTIwOTZlNDYxXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 2,
				Name = "Ellis Boyd 'Red' Redding",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZGVmZjg5NTEtMjJhNS00OWJjLThjOTYtZTk0NjUwMjA3MjkyXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 3,
				Name = "Captain Hadley",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BODUzYTVhM2EtODVjOS00ODFkLWFjNjItNGEzOWFmNTgyZDI2XkEyXkFqcGdeQXVyOTc5MDI5NjE@._V1_FMjpg_UX600_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 4,
				Name = "Carlo Rizzi",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BYjhiMGExMmYtM2RlOC00OTFmLWFmODQtMjkxMjZkNjk0ZTIzXkEyXkFqcGdeQXVyMTIwODk1NTQ@._V1_FMjpg_UX600_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 5,
				Name = "Michael Corleone",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDhkYzhiYjEtMTQwYy00MTdmLTlkOTAtYTk1YmMyYmE5NDVmXkEyXkFqcGdeQXVyMDc2NTEzMw@@._V1_FMjpg_UY337_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 6,
				Name = "Kay Adams",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BYmMyZTNiZjItMjZkOC00NDRkLTg5YTEtZDFjODBlODliYjYxXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 7,
				Name = "Bruce Wayne, Batman",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BYmMyZTNiZjItMjZkOC00NDRkLTg5YTEtZDFjODBlODliYjYxXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 8,
				Name = "Kay Adams",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BYmMyZTNiZjItMjZkOC00NDRkLTg5YTEtZDFjODBlODliYjYxXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 9,
				Name = "Kay Adams",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BYmMyZTNiZjItMjZkOC00NDRkLTg5YTEtZDFjODBlODliYjYxXkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_.jpg",
			};

			movieCharacters.Add(movieCharacter);
		}
	}
}
