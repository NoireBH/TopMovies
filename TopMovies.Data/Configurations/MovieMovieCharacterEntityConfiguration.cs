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
	public class MovieMovieCharacterEntityConfiguration : IEntityTypeConfiguration<MovieMovieCharacter>
	{
		public void Configure(EntityTypeBuilder<MovieMovieCharacter> builder)
		{
			builder.HasData(SeedMovieMovieCharacters());
		}

		private MovieMovieCharacter[] SeedMovieMovieCharacters()
		{
			var movieMovieCharacters = new HashSet<MovieMovieCharacter>();

			MovieMovieCharacter movie;

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				MovieCharacterId = 1
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				MovieCharacterId = 2
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				MovieCharacterId = 3
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				MovieCharacterId = 4
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				MovieCharacterId = 5
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				MovieCharacterId = 6
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				MovieCharacterId = 7
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				MovieCharacterId = 8
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				MovieCharacterId = 9
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				MovieCharacterId = 10
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				MovieCharacterId = 11
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				MovieCharacterId = 12
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				MovieCharacterId = 13
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				MovieCharacterId = 14
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				MovieCharacterId = 15
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),
				MovieCharacterId = 16
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),
				MovieCharacterId = 17
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),
				MovieCharacterId = 18
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),
				MovieCharacterId = 10
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),
				MovieCharacterId = 20
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),
				MovieCharacterId = 21
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),
				MovieCharacterId = 22
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),
				MovieCharacterId = 23
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),
				MovieCharacterId = 24
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
				MovieCharacterId = 25
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
				MovieCharacterId = 26
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
				MovieCharacterId = 27
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
				MovieCharacterId = 28
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
				MovieCharacterId = 29
			};

			movieMovieCharacters.Add(movie);

			movie = new MovieMovieCharacter()
			{
				MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
				MovieCharacterId = 30
			};

			movieMovieCharacters.Add(movie);

			return movieMovieCharacters.ToArray();
		}
	}
}
