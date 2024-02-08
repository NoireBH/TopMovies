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
			builder.HasData(SeedMovies());
		}

		private Movie[] SeedMovies()
		{

			var movies = new HashSet<Movie>();

			Movie movie;

			movie = new Movie()
			{
				Id = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				Name = "The Shawshank Redemption",
				Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
				ReleaseDate = 1994,
				Rating = 9.3,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg"
				
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				Name = "The Godfather",
				Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
				ReleaseDate = 1972,
				Rating = 9.2,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UY1982_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				Name = "Saw",
				Description = "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.",
				ReleaseDate = 2004,
				Rating = 7.6,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2M1MzI1MWYtYmM2ZC00OWY3LTk0ZGMtNmRkNzU1NzEzMWE5XkEyXkFqcGdeQXVyODUwOTkwODk@._V1_FMjpg_UX1000_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				Name = "The Dark Knight",
				Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.\r\n\r\n",
				ReleaseDate = 2008,
				Rating = 9.0,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UY2048_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				Name = "Pulp Fiction",
				Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.\r\n\r\n",
				ReleaseDate = 1994,
				Rating = 8.9,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1055_.jpg"
			};

			movies.Add(movie);

			return movies.ToArray();
		}
	}
}
