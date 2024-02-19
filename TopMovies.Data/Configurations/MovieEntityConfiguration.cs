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
				ReleaseDate = new DateTime(1994, 9, 10),
				Rating = 9.3,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg"
				
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				Name = "The Godfather",
				Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
				ReleaseDate = new DateTime(1972, 3, 14),
                Rating = 9.2,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UY1982_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				Name = "Saw",
				Description = "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.",
				ReleaseDate = new DateTime(2004, 1, 19),
                Rating = 7.6,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2M1MzI1MWYtYmM2ZC00OWY3LTk0ZGMtNmRkNzU1NzEzMWE5XkEyXkFqcGdeQXVyODUwOTkwODk@._V1_FMjpg_UX1000_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				Name = "The Dark Knight",
				Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
				ReleaseDate = new DateTime(2008, 7, 14),
                Rating = 9.0,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UY2048_.jpg"
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				Name = "Pulp Fiction",
				Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
				ReleaseDate = new DateTime(1994, 5, 21),
				Rating = 8.9,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1055_.jpg"
			};

			movies.Add(movie);

            movie = new Movie()
            {
                Id = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),
                Name = "Five Nights at Freddy's",
                Description = "A troubled security guard begins working at Freddy Fazbear's Pizza. During his first night on the job, he realizes that the night shift won't be so easy to get through. Pretty soon he will unveil what actually happened at Freddy's.",
                ReleaseDate = new DateTime(1994, 5, 21),
                Rating = 5.5,
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNmNlZWI4MDQtMzFlYS00NzJmLTkwZjItZWVmNmJjZGYxNDA1XkEyXkFqcGdeQXVyMTM0NTUzNDIy._V1_FMjpg_UX1000_.jpg"
            };

            movies.Add(movie);

            movie = new Movie()
            {
                Id = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),
                Name = "It",
                Description = "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.\r\n\r\n",
                ReleaseDate = new DateTime(2017, 9, 5),
                Rating = 7.3,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDVkZmI0YzAtNzdjYi00ZjhhLWE1ODEtMWMzMWMzNDA0NmQ4XkEyXkFqcGdeQXVyNzYzODM3Mzg@._V1_.jpg"
            };

            movies.Add(movie);

            movie = new Movie()
            {
                Id = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),
                Name = "Drive",
                Description = "A mysterious Hollywood action film stuntman gets in trouble with gangsters when he tries to help his neighbor's husband rob a pawn shop while serving as his getaway driver.\r\n\r\n",
                ReleaseDate = new DateTime(2011, 5, 20),
                Rating = 7.8,
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjY5ZjQyMjMtMmEwOC00Nzc2LTllYTItMmU2MzJjNTg1NjY0XkEyXkFqcGdeQXVyNjQ1MTMzMDQ@._V1_FMjpg_UX1000_.jpg"
            };

            movies.Add(movie);

            movie = new Movie()
            {
                Id = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
                Name = "Barbie",
                Description = "Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.\r\n\r\n",
                ReleaseDate = new DateTime(2023, 7, 9),
                Rating = 6.9,
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjU3N2QxNzYtMjk1NC00MTc4LTk1NTQtMmUxNTljM2I0NDA5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_FMjpg_UX1000_.jpg"
            };

            movies.Add(movie);

            movie = new Movie()
            {
                Id = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
                Name = "Blade Runner 2049",
                Description = "Young Blade Runner K's discovery of a long-buried secret leads him to track down former Blade Runner Rick Deckard, who's been missing for thirty years.",
                ReleaseDate = new DateTime(2017, 10, 3),
                Rating = 8.0,
                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzA1Njg4NzYxOV5BMl5BanBnXkFtZTgwODk5NjU3MzI@._V1_FMjpg_UX1000_.jpg"
            };

            movies.Add(movie);

            return movies.ToArray();
		}
	}
}
