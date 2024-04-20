using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels;
using System.Reflection;
using TopMovies.Data.Models;
using TopMovies.Web.ViewModels.Genres;

namespace TopMovies.Services.Data.Tests
{
	public class GenreServiceTests
	{
		private DbContextOptions<TopMoviesDbContext> dbOptions;
		private TopMoviesDbContext context;
		private IGenreService service;

		[SetUp]
		public void SetUp()
		{
			dbOptions = new DbContextOptionsBuilder<TopMoviesDbContext>()
				.UseInMemoryDatabase("TopMoviesInMemory" + Guid.NewGuid())
				.Options;
			context = new TopMoviesDbContext(dbOptions);
			service = new GenreService(context);

			AutoMapperConfig.RegisterMappings(
			typeof(ActorDetailsViewModel).GetTypeInfo().Assembly,
			typeof(ErrorViewModel).GetTypeInfo().Assembly);

			Seed();
		}

		[TearDown]
		public void TearDownDb() => context.Dispose();

		[Test]
		public async Task AddGenreToMovieAsyncShouldAddCorrectly()
		{
			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD".ToLower();


			var model = new MovieGenreAddOrEditFormModel()
			{
				MovieId = movieId,
				GenreId = 1
			};

			await service.AddGenreToMovieAsync(model, movieId);

			bool actual =  context.Movies.Any(m => m.MovieGenres.Any(mg => mg.GenreId == 1));

			Assert.That(actual, Is.True);
		}

		[Test]
		public async Task AddGenreAsyncShouldIncreaseCountAndAddGenre()
		{
			int expectedCount = 6;
			string expectedName = "History";

			var model = new GenreAddOrEditFormModel()
			{
				Id =6,
				Name = "History"
			};

			await service.AddGenreAsync(model);
			var genre = context.Genres.FirstOrDefault(m => m.Id == 6);

			Assert.That(genre!.Id, Is.EqualTo(6));
			Assert.That(context.Genres.Count(), Is.EqualTo(expectedCount));
			Assert.That(genre.Name, Is.EqualTo(expectedName));
		}

		[Test]
		public async Task ExistsByNameAsyncShouldReturnTrueIfGenreExists()
		{
			string name = "Action";

			bool actual = await service.ExistsByNameAsync(name);
			Assert.IsTrue(actual);
		}

		[Test]
		public async Task ExistsByNameAsyncShouldReturnFalseIfGenreDoesntExists()
		{
			string name = "Gibberish";

			bool actual = await service.ExistsByNameAsync(name);
			Assert.IsFalse(actual);
		}

		[Test]
		public async Task ExistsByIdAsyncShouldReturnTrueIfGenreExists()
		{
			int id = 1;

			bool actual = await service.ExistsByIdAsync(id);
			Assert.IsTrue(actual);
		}

		[Test]
		public async Task ExistsByIdAsyncShouldReturnFalseIfGenreDoesntExists()
		{
			int id = 15;

			bool actual = await service.ExistsByIdAsync(id);
			Assert.IsFalse(actual);
		}

		[Test]
		public async Task GetAllGenresAsyncShouldReturnCorrectCount()
		{
			int expected = 5;

			var genres = await service.GetAllGenresAsync();
			Assert.That(genres.Count(), Is.EqualTo(expected));
		}

		[Test]
		public async Task GetMovieGenresByMovieIdAsyncShouldReturnCorrectGenres()
		{
			int expectedGenre = 4;
			int expectedGenre2 = 5;
			int expectedCount = 2;
			string movieId = "30DA4459-9475-404D-92FB-9124CFF7CFA6".ToLower();

			var movieGenres = await service.GetMovieGenresByMovieIdAsync(movieId);

			Assert.That(movieGenres.Count(), Is.EqualTo(expectedCount));
			Assert.IsTrue(movieGenres.Any(mg => mg.GenreId == expectedGenre));
			Assert.IsTrue(movieGenres.Any(mg => mg.GenreId == expectedGenre2));
		}

		[Test]
		public async Task MovieGenreExistsByGenreAndMovieIdShouldReturnTrueIfGenreExists()
		{
			string movieId = "30DA4459-9475-404D-92FB-9124CFF7CFA6".ToLower();
			int genreId = 5;

			bool actual = await service.MovieGenreExistsByGenreAndMovieId(genreId,movieId);

			Assert.IsTrue(actual);
		}

		[Test]
		public async Task MovieGenreExistsByGenreAndMovieIdShouldReturnFalseIfGenreDoesntExists()
		{
			string movieId = "30DA4459-9475-404D-92FB-9124CFF7CFA6".ToLower();
			int genreId = 49;

			bool actual = await service.MovieGenreExistsByGenreAndMovieId(genreId, movieId);

			Assert.IsFalse(actual);
		}

		[Test]
		public async Task DeleteGenreFromMovieByGenreAndMovieIdAsyncShouldDecreaseCountAndDeleteGenreFromMovie()
		{
			string movieId = "30DA4459-9475-404D-92FB-9124CFF7CFA6".ToLower();
			int genreId = 5;
			int expectedCount = 1;

			await service.DeleteGenreFromMovieByGenreAndMovieIdAsync(genreId, movieId);

			int actualCount = await context.MovieGenres.CountAsync();
			bool deletedGenreExists = await service.MovieGenreExistsByGenreAndMovieId(genreId, movieId);

			Assert.IsFalse(deletedGenreExists);
			Assert.That(actualCount, Is.EqualTo(expectedCount));
		}

		private void Seed()
		{
			Genre genre;

			genre = new Genre()
			{
				Id = 1,
				Name = "Action"
			};

			context.Genres.Add(genre);

			genre = new Genre()
			{
				Id = 2,
				Name = "Animation"
			};

			context.Genres.Add(genre);

			genre = new Genre()
			{
				Id = 3,
				Name = "Comedy"
			};

			context.Genres.Add(genre);

			genre = new Genre()
			{
				Id = 4,
				Name = "Crime"
			};

			context.Genres.Add(genre);


			genre = new Genre()
			{
				Id = 5,
				Name = "Drama"
			};

			context.Genres.Add(genre);


			Movie movie;

			movie = new Movie()
			{
				Id = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				Name = "The Shawshank Redemption",
				Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
				ReleaseDate = new DateTime(1994, 9, 10),
				TrailerUrl = "https://www.youtube.com/embed/NmzuHjWmXOc",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg",

			};

			context.Movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				Name = "The Godfather",
				Description = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
				ReleaseDate = new DateTime(1972, 3, 14),
				TrailerUrl = "https://www.youtube.com/embed/sY1S34973zA",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2MyNjYxNmUtYTAwNi00MTYxLWJmNWYtYzZlODY3ZTk3OTFlXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_FMjpg_UY1982_.jpg"
			};

			context.Movies.Add(movie);

			movie = new Movie()
			{
				Id = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				Name = "Saw",
				Description = "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.",
				ReleaseDate = new DateTime(2004, 1, 19),
				TrailerUrl = "https://www.youtube.com/embed/S-1QgOMQ-ls",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BM2M1MzI1MWYtYmM2ZC00OWY3LTk0ZGMtNmRkNzU1NzEzMWE5XkEyXkFqcGdeQXVyODUwOTkwODk@._V1_FMjpg_UX1000_.jpg"
			};

			context.Movies.Add(movie);

			MovieGenre movieGenre;

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				GenreId = 5
			};

			context.MovieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				GenreId = 4
			};

			context.MovieGenres.Add(movieGenre);

			context.SaveChanges();
		}
	}
}
