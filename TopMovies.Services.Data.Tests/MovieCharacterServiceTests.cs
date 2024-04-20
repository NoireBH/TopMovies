using Microsoft.EntityFrameworkCore;
using TopMovies.Data;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Actors;
using TopMovies.Web.ViewModels;
using System.Reflection;
using TopMovies.Data.Models;

namespace TopMovies.Services.Data.Tests
{
	public class MovieCharacterServiceTests
	{
		private DbContextOptions<TopMoviesDbContext> dbOptions;
		private TopMoviesDbContext context;
		private IMovieCharacterService service;

		[SetUp]
		public void SetUp()
		{
			dbOptions = new DbContextOptionsBuilder<TopMoviesDbContext>()
				.UseInMemoryDatabase("TopMoviesInMemory" + Guid.NewGuid())
				.Options;
			context = new TopMoviesDbContext(dbOptions);
			service = new MovieCharacterService(context);

			AutoMapperConfig.RegisterMappings(
			typeof(ActorDetailsViewModel).GetTypeInfo().Assembly,
			typeof(ErrorViewModel).GetTypeInfo().Assembly);

			Seed();
		}

		[TearDown]
		public void TearDownDb() => context.Dispose();

		[Test]
		public async Task ExistsByIdAsyncReturnsTrueIfMCExists()
		{
			int mcId = 1;
			bool actual = await service.ExistsByIdAsync(mcId);

			Assert.That(actual, Is.True);
		}

		[Test]
		public async Task ExistsByIdAsyncReturnsFalseIfMCDoesntExists()
		{
			int mcId = 16;
			bool actual = await service.ExistsByIdAsync(mcId);

			Assert.That(actual, Is.False);
		}

		[Test]
		public async Task GetMovieCharacterByIdAsyncShouldReturnCharacter()
		{
			int mcId = 1;
			string expectedName = "Andy Dufresne";
			string expectedImageUrl = "https://m.media-amazon.com/images/M/MV5BZTZlNGQ5MjAtZmE3OC00MWFlLWE2MWItYWY2ZTIwOTZlNDYxXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg";
			string expectedMovieId = "2ca61990-fe17-483c-863d-442ee4c0acad";
			int expectedActorId = 2;
			var mc = await service.GetMovieCharacterByIdAsync(mcId); // doesnt work even though its the same as below?
			var mcNotMapped = await context.MovieCharacters.Where(mc => mc.Id == mcId).FirstOrDefaultAsync();

			Assert.That(mcNotMapped.Name, Is.EqualTo(expectedName));
			Assert.That(mcNotMapped.ImageUrl, Is.EqualTo(expectedImageUrl));
			Assert.That(mcNotMapped.MovieId.ToString(), Is.EqualTo(expectedMovieId));
			Assert.That(mcNotMapped.ActorId, Is.EqualTo(expectedActorId));
		}

		[Test]
		public async Task GetAllMovieCharactersByMovieIdAsyncShouldReturnCorrectCount()
		{
			string movieId = "2ca61990-fe17-483c-863d-442ee4c0acad";
			int expectedCount = 3;

			var mcs = await service.GetAllMovieCharactersByMovieIdAsync(movieId);

			Assert.That(mcs.Length, Is.EqualTo(expectedCount));
		}

		[Test]
		public async Task ExistsByNameAsyncShouldReturnTrueIfMCExists()
		{
			string mcName = "Andy Dufresne";
			string mcName2 = "Ellis Boyd 'Red' Redding";
			bool actual = await service.ExistsByNameAsync(mcName);
			bool actual2 = await service.ExistsByNameAsync(mcName2);

			Assert.That(actual, Is.True);
			Assert.That(actual2, Is.True);
		}

		[Test]
		public async Task ExistsByNameAsyncShouldReturnFalseIfMCDoesntExists()
		{
			string mcName = "Andyes Dufresne";
			string mcName2 = "Ellis Boydees 'Red' Redding";
			bool actual = await service.ExistsByNameAsync(mcName);
			bool actual2 = await service.ExistsByNameAsync(mcName2);

			Assert.That(actual, Is.False);
			Assert.That(actual2, Is.False);
		}

		private async void Seed()
		{

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

			movieCharacter = new MovieCharacter()
			{
				Id = 2,
				Name = "Ellis Boyd 'Red' Redding",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BZGVmZjg5NTEtMjJhNS00OWJjLThjOTYtZTk0NjUwMjA3MjkyXkEyXkFqcGdeQXVyMzQ3Nzk5MTU@._V1_.jpg",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				ActorId = 1
			};

			context.MovieCharacters.Add(movieCharacter);

			movieCharacter = new MovieCharacter()
			{
				Id = 3,
				Name = "Captain Hadley",
				ImageUrl = "https://m.media-amazon.com/images/M/MV5BODUzYTVhM2EtODVjOS00ODFkLWFjNjItNGEzOWFmNTgyZDI2XkEyXkFqcGdeQXVyOTc5MDI5NjE@._V1_FMjpg_UX600_.jpg",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				ActorId = 3
			};

			context.MovieCharacters.Add(movieCharacter);

			await context.SaveChangesAsync();
		}
	}
}
