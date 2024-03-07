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
			builder.HasData(SeedMovieCharacters());
		}

		private MovieCharacter[] SeedMovieCharacters()
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
				Name = "Joker",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA5ODU3NTI0Ml5BMl5BanBnXkFtZTcwODczMTk2Mw@@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 9,
				Name = "Scarecrow",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BY2FkYmExNTMtYTkxNS00NzA0LTliYTktOTNjNjEwZmRlMTU2XkEyXkFqcGdeQXVyNDIyNjA2MTk@._V1_.jpgg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 10,
				Name = "Adam",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTUxMDgyMTg3N15BMl5BanBnXkFtZTcwMDY2OTYwNA@@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 11,
				Name = "Dr. Lawrence Gordon",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDdmMDA3NzItYmNlYi00NjU3LWJlZGYtMDYxNzg0OWUzNDJjXkEyXkFqcGdeQXVyNjQ4ODE4MzQ@._V1_FMjpg_UX1280_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 12,
				Name = "Jigsaw",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTM0MzIwMTI5OV5BMl5BanBnXkFtZTcwOTg1NjAxNQ@@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 13,
				Name = "Vincent Vega",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BYTMzOWFiMTEtZGFjOS00OWEyLTlhYmEtOGRlZmNkZjhhNmJhXkEyXkFqcGdeQXVyNDIyNjA2MTk@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 14,
				Name = "Mia Wallace",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzg1MTgwMTUzM15BMl5BanBnXkFtZTcwNjA0MzU5Ng@@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 15,
				Name = "Jules Winnfield",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjIwNTg0Mjc4Nl5BMl5BanBnXkFtZTcwODAzNDY3Mw@@._V1_FMjpg_UX660_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 16,
				Name = "Mike",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjkwZTllMzgtMDAyOC00MDgzLWE4NmUtOTZmNzQ5NTY1NGIzXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_FMjpg_UX1920_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 17,
				Name = "Vanessa",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzdkNjBmYzItMDZjMC00ZTFkLThmYWYtNDY5OWNiNTZlZjViXkEyXkFqcGdeQXVyMTY2MDI5OTg3._V1_FMjpg_UX1170_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 18,
				Name = "William Afton",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzc1N2M0MWQtZTQ3NS00MmVmLWE1NDctOTg5MWQ0ZmEyMjk2XkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_FMjpg_UX1920_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 19,
				Name = "Pennywise",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTg1NTU5NTgwOV5BMl5BanBnXkFtZTgwMTQ1NzMzMzI@._V1_FMjpg_UX1280_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 20,
				Name = "Richie Tozier",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTk2Nzg4NzUyMF5BMl5BanBnXkFtZTgwNDM1NzMzMzI@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 21,
				Name = "Bill Denbrough",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjE2MTg2OTM0Nl5BMl5BanBnXkFtZTgwNTM1NzMzMzI@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 22,
				Name = "Driver",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNTM1NDk2OTE3M15BMl5BanBnXkFtZTcwMTM1NTgxNQ@@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 23,
				Name = "Shannon",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDgwMDMxMzQ5MF5BMl5BanBnXkFtZTcwMTEwMDk3NQ@@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 24,
				Name = "Irene",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTc2NTI1MzU5NF5BMl5BanBnXkFtZTcwMDAwMDk3NQ@@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 25,
				Name = "Barbie",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZTM1NzVmZTItYmU0Zi00ODVmLWE4MWQtZTFlMzRiZmMxN2I4XkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_FMjpg_UY5791_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 26,
				Name = "Ken",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMmY1NjBlNWEtZjNlZS00YmY3LWE5MTAtOWE3ZjAzYmQ3OTJjXkEyXkFqcGdeQXVyODk4OTc3MTY@._V1_FMjpg_UY4976_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 27,
				Name = "Weird Barbie",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDE1ZjJmMTMtYmJlZi00N2VjLWFkMmMtZTNjMDdjMGQ1NzU5XkEyXkFqcGdeQXVyMjY1OTQ0MDA@._V1_FMjpg_UX2160_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 28,
				Name = "'K'",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTA0MzA5MjU4ODFeQTJeQWpwZ15BbWU4MDYzOTI2NjMy._V1_FMjpg_UX1280_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 29,
				Name = "Rick Deckard",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjQ1MzQ2NTM3Ml5BMl5BanBnXkFtZTgwMzI5MjY2MzI@._V1_FMjpg_UX2048_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 30,
				Name = "Sapper Morton",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjE4MzcyMzMtZDM0ZS00ZWQ4LTg2N2MtMGEwZDE1OTBkNTYxXkEyXkFqcGdeQXVyNzg2ODI2OTU@._V1_FMjpg_UX2160_.jpg",
			};

			movieCharacters.Add(movieCharacter);

			return movieCharacters.ToArray();
		}
	}
}
