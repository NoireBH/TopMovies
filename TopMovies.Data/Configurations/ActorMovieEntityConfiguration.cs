using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopMovies.Data.Models;
namespace TopMovies.Data.Configurations
{
	public class ActorMovieEntityConfiguration : IEntityTypeConfiguration<ActorMovie>
	{
		public void Configure(EntityTypeBuilder<ActorMovie> builder)
		{
			builder.HasData(SeedActorMovies());
		}

		private ActorMovie[] SeedActorMovies()
		{
			var actorMovies = new HashSet<ActorMovie>();

			ActorMovie actorMovie;

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				ActorId = 1
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				ActorId = 2
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				ActorId = 3
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				ActorId = 4
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				ActorId = 5
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				ActorId = 6
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				ActorId = 7
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				ActorId = 8
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				ActorId = 9
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				ActorId = 10
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				ActorId = 11
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				ActorId = 12
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				ActorId = 13
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				ActorId = 14
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				ActorId = 28
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),
				ActorId = 15
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),
				ActorId = 16
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),
				ActorId = 17
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),
				ActorId = 18
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),
				ActorId = 19
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),
				ActorId = 20
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),
				ActorId = 21
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),
				ActorId = 22
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),
				ActorId = 23
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
				ActorId = 21
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
				ActorId = 24
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
				ActorId = 25
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
				ActorId = 21
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
				ActorId = 26
			};

			actorMovies.Add(actorMovie);

			actorMovie = new ActorMovie()
			{
				MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
				ActorId = 27
			};

			actorMovies.Add(actorMovie);

			return actorMovies.ToArray();
		}
	}
}
