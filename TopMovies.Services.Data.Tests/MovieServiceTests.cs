using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Data.Models;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels.Movies;
using System.Reflection;
using TopMovies.Web.ViewModels;
using AutoMapper;

namespace TopMovies.Services.Data.Tests
{
	public class MovieServiceTests
	{
		private DbContextOptions<TopMoviesDbContext> dbOptions;
		private TopMoviesDbContext context;
		private IMovieService service;

		[SetUp]
		public void SetUp()
		{
			dbOptions = new DbContextOptionsBuilder<TopMoviesDbContext>()
				.UseInMemoryDatabase("TopMoviesInMemory" + Guid.NewGuid())
				.Options;
			context = new TopMoviesDbContext(dbOptions);
			service = new MovieService(context);

			AutoMapperConfig.RegisterMappings(
			typeof(ActorDetailsViewModel).GetTypeInfo().Assembly,
			typeof(ErrorViewModel).GetTypeInfo().Assembly);

			Seed();
		}

		[TearDown]
		public void TearDownDb() => context.Dispose();

		[Test]
		public async Task AddMovieAsyncShouldAddMovieToDb()
		{
			var movie = new MovieAddOrEditFormModel()
			{
				Id = Guid.Parse("EC519399-6814-4E58-B382-E0C516834F04"),
				Name = "Test",
				Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion.",
				ReleaseDate = new DateTime(1994, 9, 10),
				TrailerUrl = "https://www.youtube.com/embed/NmzuHjWmXOc",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg",

			};

			await service.AddMovieAsync(movie);

			Assert.That(context.Movies.Count(), Is.EqualTo(4));
		}

		[Test]
		public async Task DeleteAsyncShouldDeleteMovie()
		{
			string movieId = "13b84726-1968-4206-9f4b-856a4ba9998a";
			await service.DeleteAsync(movieId);

			Assert.That(context.Movies.Count(), Is.EqualTo(2));
		}

		[Test]
		public async Task EditMovieShouldEditTheMovie()
		{
			var movie = new MovieAddOrEditFormModel()
			{
				Id = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				Name = "Edit",
				Description = "Edit",
				ReleaseDate = new DateTime(1990, 9, 10),
				TrailerUrl = "Edit",
				ImageUrl = "Edit",

			};

			await service.EditMovie(movie);

			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD".ToLower();

			var editedMovie = await context.Movies.FirstAsync(h => h.Id.ToString() == movieId);

			Assert.That(editedMovie.Name, Is.EqualTo("Edit"));
			Assert.That(editedMovie.Description, Is.EqualTo("Edit"));
			Assert.That(editedMovie.TrailerUrl, Is.EqualTo("Edit"));
			Assert.That(editedMovie.ImageUrl, Is.EqualTo("Edit"));
			Assert.That(editedMovie.ReleaseDate, Is.EqualTo(new DateTime(1990, 9, 10)));
		}

		[Test]
		public async Task ExistByIdShouldReturnTrueIfMovieExists()
		{
			string movieId = "13b84726-1968-4206-9f4b-856a4ba9998a";
			var exists = await service.ExistsByIdAsync(movieId);

			Assert.That(exists, Is.EqualTo(true));
		}

		[Test]
		public async Task ExistByIdShouldReturnFalseIfMovieDoesntExists()
		{
			string movieId = "13b84726-1968-4206-9f4b-856a4ba9998asssss";
			var exists = await service.ExistsByIdAsync(movieId);

			Assert.That(exists, Is.EqualTo(false));
		}

		[Test]
		public async Task ExistsByNameAndReleaseDateShouldReturnTrueIfMovieExists()
		{
			string movieName = "The Godfather";
			int movieYear = 1972;
			int movieMonth = 3;
			int movieDay = 14;
			var exists = await service.ExistsByNameAndReleaseDate(movieName, movieYear, movieMonth, movieDay);

			Assert.That(exists, Is.EqualTo(true));
		}

		[Test]
		public async Task ExistsByNameAndReleaseDateShouldReturnFalseIfMovieDoesntExists()
		{
			string movieName = "The Godfather doesnt exist";
			int movieYear = 1999;
			int movieMonth = 3;
			int movieDay = 14;
			var exists = await service.ExistsByNameAndReleaseDate(movieName, movieYear, movieMonth, movieDay);

			Assert.That(exists, Is.EqualTo(false));
		}

		[Test]
		public async Task GetFeaturedMoviesAsyncShouldReturn3MoviesAtRandom()
		{
			var movies = await service.GetFeaturedMoviesAsync();
			Assert.That(movies.Count(), Is.EqualTo(3));
		}

		[Test]
		public async Task GetMovieActorsAndCharactersByMovieIdAsyncShouldReturnMovieActorsAndTheirCharacters()
		{
			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD".ToLower();
			var movieCharactersNoMap = await context.MovieCharacters
				.Where(mc => mc.MovieId.ToString() == movieId)
				.ToArrayAsync();

			var movieCharacters = await service.GetMovieActorsAndCharactersByMovieIdAsync(movieId);

			Assert.That(movieCharactersNoMap.Count(), Is.EqualTo(2));
		}

		[Test]
		public async Task GetMoviesBySearchTermShouldReturnCorrectMovies()
		{			
			string term = "god";

			var movies = await service.GetMoviesBySearchTerm(term);

			Assert.That(movies.Count(), Is.EqualTo(1));
		}

		[Test]
		public async Task GetMoviesCountShouldReturnCorrectly()
		{

			var movieCount = await service.GetMovieCountAsync();

			Assert.That(movieCount, Is.EqualTo(3));
		}

		[Test]
		public async Task GetMovieDetailsByIdAsyncShouldReturnCorrectMovie()
		{
			string movieId = "2CA61990-FE17-483C-863D-442EE4C0ACAD";

			var movie = await service.GetMovieDetailsByIdAsync(movieId);

			Assert.That(movie.Name, Is.EqualTo("The Shawshank Redemption"));
			Assert.That(movie.ImageUrl, Is.EqualTo("https://m.media-amazon.com/images/M/MV5BNDE3ODcxYzMtY2YzZC00NmNlLWJiNDMtZDViZWM2MzIxZDYwXkEyXkFqcGdeQXVyNjAwNDUxODI@._V1_FMjpg_UX1200_.jpg"));
			Assert.That(movie.Description, Is.EqualTo("Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."));
		}

		private void Seed()
		{

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

			context.SaveChanges();

			MovieCharacter movieCharacter;

			movieCharacter = new MovieCharacter()
			{
				Id = 1,
				Name = "Andy Dufresne",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZTZlNGQ5MjAtZmE3OC00MWFlLWE2MWItYWY2ZTIwOTZlNDYxXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				ActorId = 2
			};

			context.MovieCharacters.Add(movieCharacter);

			context.SaveChanges();

			movieCharacter = new MovieCharacter()
			{
				Id = 2,
				Name = "Ellis Boyd 'Red' Redding",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZGVmZjg5NTEtMjJhNS00OWJjLThjOTYtZTk0NjUwMjA3MjkyXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				ActorId = 1
			};

			context.MovieCharacters.Add(movieCharacter);

			context.SaveChanges();
		}
	}
}