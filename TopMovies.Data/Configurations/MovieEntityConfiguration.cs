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
				TrailerUrl = "https://www.youtube.com/embed/NmzuHjWmXOc",
				Rating = 9.3,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg",
				Photos = new List<Photo>()
				{
					new Photo() {Id = 1, MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTM0NjUxMDk5MF5BMl5BanBnXkFtZTcwNDMxNDY3Mw@@._V1_FMjpg_UX1800_.jpg"},
					new Photo() {Id = 2, MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTk3NDE2Nzg3Nl5BMl5BanBnXkFtZTcwNTMxNDY3Mw@@._V1_FMjpg_UX2048_.jpg"},
					new Photo() {Id = 3, MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTg0MDgwNjc5N15BMl5BanBnXkFtZTcwNjMxNDY3Mw@@._V1_FMjpg_UY2048_.jpg"},
				}

			};


			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				Name = "The Godfather",
				Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
				ReleaseDate = new DateTime(1972, 3, 14),
				TrailerUrl = "https://www.youtube.com/embed/sY1S34973zA",
				Rating = 9.2,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UY1982_.jpg",
				Photos = new[]
				{
					new Photo() {MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),ImageURl = "https://m.media-amazon.com/images/M/MV5BZTFiODA5NWEtM2FhNC00MWEzLTlkYjgtMWMwNzBhYzlkY2U3XkEyXkFqcGdeQXVyMDM2NDM2MQ@@._V1_FMjpg_UY4281_.jpg"},
					new Photo() {MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTczMTk5MjkwOF5BMl5BanBnXkFtZTgwMDI0Mjk1NDM@._V1_FMjpg_UX2048_.jpg"},
					new Photo() {MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),ImageURl = "https://m.media-amazon.com/images/M/MV5BYTgzZTJlMDUtMGIxNy00ODJiLWI3NjAtYzQ4OTQ3MGQ3ZGYwXkEyXkFqcGdeQXVyMDc2NTEzMw@@._V1_FMjpg_UY3600_.jpg"},
				}
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				Name = "Saw",
				Description = "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.",
				ReleaseDate = new DateTime(2004, 1, 19),
				TrailerUrl = "https://www.youtube.com/embed/S-1QgOMQ-ls",
				Rating = 7.6,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2M1MzI1MWYtYmM2ZC00OWY3LTk0ZGMtNmRkNzU1NzEzMWE5XkEyXkFqcGdeQXVyODUwOTkwODk@._V1_FMjpg_UX1000_.jpg",
				Photos = new[]
				{
					new Photo() {MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTk2MzE4NzU3OV5BMl5BanBnXkFtZTgwNjg0NDk5MjE@._V1_FMjpg_UX2048_.jpg"},
					new Photo() {MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMjMwMzM5OTQxNV5BMl5BanBnXkFtZTgwNTczMDk5MjE@._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTA3NzExOTYxOTFeQTJeQWpwZ15BbWU3MDc1Njk2MDQ@._V1_FMjpg_UX1280_.jpg"},
				}
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				Name = "The Dark Knight",
				Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.",
				ReleaseDate = new DateTime(2008, 7, 14),
				TrailerUrl = "https://www.youtube.com/embed/EXeTwQWrcwY",
				Rating = 9.0,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTMxNTMwODM0NF5BMl5BanBnXkFtZTcwODAyMTk2Mw@@._V1_FMjpg_UY2048_.jpg",
				Photos = new[]
				{
					new Photo() {MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMjE3NTU0NTQ5NF5BMl5BanBnXkFtZTcwNzczMTk2Mw@@._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMjA5ODU3NTI0Ml5BMl5BanBnXkFtZTcwODczMTk2Mw@@._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTM1NTcwMTk4OV5BMl5BanBnXkFtZTcwOTczMTk2Mw@@._V1_FMjpg_UX1280_.jpg"},
				}
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				Name = "Pulp Fiction",
				Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
				ReleaseDate = new DateTime(1994, 5, 21),
				TrailerUrl = "https://www.youtube.com/embed/s7EdQ4FqbhY",
				Rating = 8.9,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGNhMDIzZTUtNTBlZi00MTRlLWFjM2ItYzViMjE3YzI5MjljXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UX1055_.jpg",
				Photos = new[]
				{
					new Photo() {MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),ImageURl = "https://m.media-amazon.com/images/M/MV5BNTY1MzgzOTYxNV5BMl5BanBnXkFtZTgwMDI4OTEwMjE@._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTQ2MDk3ODAwMV5BMl5BanBnXkFtZTgwNzE4OTEwMjE@._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMjE1ODYxOTkxOF5BMl5BanBnXkFtZTgwNTE4OTEwMjE@._V1_FMjpg_UX1280_.jpg"},
				}
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),
				Name = "Five Nights at Freddy's",
				Description = "A troubled security guard begins working at Freddy Fazbear's Pizza. During his first night on the job, he realizes that the night shift won't be so easy to get through. Pretty soon he will unveil what actually happened at Freddy's.",
				ReleaseDate = new DateTime(1994, 5, 21),
				TrailerUrl = "https://www.youtube.com/embed/0VH9WCFV6XQ",
				Rating = 5.5,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNmNlZWI4MDQtMzFlYS00NzJmLTkwZjItZWVmNmJjZGYxNDA1XkEyXkFqcGdeQXVyMTM0NTUzNDIy._V1_FMjpg_UX1000_.jpg",
				Photos = new[]
				{
					new Photo() {MovieId = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),ImageURl = "https://m.media-amazon.com/images/M/MV5BNzlmYTlmZmEtMGEwNS00N2U2LWIyZGQtY2FlZTMyMmMwYjcwXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMWJlMTQ3NWItODllYy00YjQwLWIzMmYtMzVkZjg5MzhkZDVkXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),ImageURl = "https://m.media-amazon.com/images/M/MV5BZjRiZmEyZjYtYWJiZi00YTAwLWExYTMtYWExMzhiN2ExNTdlXkEyXkFqcGdeQXVyMTUzMTg2ODkz._V1_FMjpg_UX1280_.jpg"},
				}
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),
				Name = "It",
				Description = "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town.\r\n\r\n",
				ReleaseDate = new DateTime(2017, 9, 5),
				TrailerUrl = "https://www.youtube.com/embed/FnCdOQsX5kc",
				Rating = 7.3,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZDVkZmI0YzAtNzdjYi00ZjhhLWE1ODEtMWMzMWMzNDA0NmQ4XkEyXkFqcGdeQXVyNzYzODM3Mzg@._V1_.jpg",
				Photos = new[]
				{
					new Photo() {MovieId = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMjEyMzM3NjM0NF5BMl5BanBnXkFtZTgwMDQ1NzMzMzI@._V1_FMjpg_UX2048_.jpg"},
					new Photo() {MovieId = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTg1NTU5NTgwOV5BMl5BanBnXkFtZTgwMTQ1NzMzMzI@._V1_FMjpg_UX2048_.jpg"},
					new Photo() {MovieId = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTkxMzkzMDYzOV5BMl5BanBnXkFtZTgwMjQ1NzMzMzI@._V1_FMjpg_UX2048_.jpg"},
				}
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),
				Name = "Drive",
				Description = "A mysterious Hollywood action film stuntman gets in trouble with gangsters when he tries to help his neighbor's husband rob a pawn shop while serving as his getaway driver.\r\n\r\n",
				ReleaseDate = new DateTime(2011, 5, 20),
				TrailerUrl = "https://www.youtube.com/embed/KBiOF3y1W0Y",
				Rating = 7.8,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjY5ZjQyMjMtMmEwOC00Nzc2LTllYTItMmU2MzJjNTg1NjY0XkEyXkFqcGdeQXVyNjQ1MTMzMDQ@._V1_FMjpg_UX1000_.jpg",
				Photos = new[]
				{
					new Photo() {MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTQ1MTc4NDk1MF5BMl5BanBnXkFtZTcwOTg2NTc2Ng@@._V1_FMjpg_UY2048_.jpg"},
					new Photo() {MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMjA0NTI1OTY3NF5BMl5BanBnXkFtZTcwMjk2NTc2Ng@@._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMjA0NDIyMzA2NV5BMl5BanBnXkFtZTcwMzk2NTc2Ng@@._V1_FMjpg_UX1280_.jpg"},
				}
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
				Name = "Barbie",
				Description = "Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.\r\n\r\n",
				ReleaseDate = new DateTime(2023, 7, 9),
				TrailerUrl = "https://www.youtube.com/embed/pBk4NYhWNMM",
				Rating = 6.9,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjU3N2QxNzYtMjk1NC00MTc4LTk1NTQtMmUxNTljM2I0NDA5XkEyXkFqcGdeQXVyODE5NzE3OTE@._V1_FMjpg_UX1000_.jpg",
				Photos =  new[]
				{
					new Photo() {MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMjNjMDA4YTgtMGJjZS00ZmVmLThlYWEtMjhmYTY1MmRiNjJjXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),ImageURl = "https://m.media-amazon.com/images/M/MV5BNzBkOGQwNDktN2Y3Yy00NWU1LWEyOTYtZTU5ZDRiYWViYjBmXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMjVkN2EwMmEtMmMzNy00ZWExLTlhNjktN2RlMTVkNzM5NWNhXkEyXkFqcGdeQXVyMTkxNjUyNQ@@._V1_FMjpg_UY6130_.jpg"},
				}
			};

			movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
				Name = "Blade Runner 2049",
				Description = "Young Blade Runner K's discovery of a long-buried secret leads him to track down former Blade Runner Rick Deckard, who's been missing for thirty years.",
				ReleaseDate = new DateTime(2017, 10, 3),
				TrailerUrl = "https://www.youtube.com/embed/gCcx85zbxz4",
				Rating = 8.0,
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzA1Njg4NzYxOV5BMl5BanBnXkFtZTgwODk5NjU3MzI@._V1_FMjpg_UX1000_.jpg",
				Photos = new []
				{
					new Photo() {MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTg3NDIwNzU3MF5BMl5BanBnXkFtZTgwMDQ5MjY2MzI@._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),ImageURl = "https://m.media-amazon.com/images/M/MV5BMTU5NTkwNTA2NF5BMl5BanBnXkFtZTgwMjQ5MjY2MzI@._V1_FMjpg_UX1280_.jpg"},
					new Photo() {MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),ImageURl = "https://m.media-amazon.com/images/M/MV5BNDc5NjM5MzY5N15BMl5BanBnXkFtZTgwNTQ5MjY2MzI@._V1_FMjpg_UX1280_.jpg"},
				}
			};

			movies.Add(movie);

			return movies.ToArray();
		}
	}
}
