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
	public class MovieGenreEntityConfiguration : IEntityTypeConfiguration<MovieGenre>
	{
		public void Configure(EntityTypeBuilder<MovieGenre> builder)
		{
			builder.HasData(SeedMovieGenres());
		}

		private MovieGenre[] SeedMovieGenres()
		{
			var movieGenres = new HashSet<MovieGenre>();

			MovieGenre movieGenre;

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD"),
				GenreId = 5
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				GenreId = 5
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("30DA4459-9475-404D-92FB-9124CFF7CFA6"),
				GenreId = 4
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				GenreId = 8
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				GenreId = 11
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("13B84726-1968-4206-9F4B-856A4BA9998A"),
				GenreId = 12
			};

			; movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				GenreId = 1
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				GenreId = 4
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("075AF806-FB6F-476D-804F-BAECBD15BDD3"),
				GenreId = 5
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				GenreId = 4
			};

			movieGenres.Add(movieGenre);
			
			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				GenreId = 5
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("FEA8731C-71A3-4980-B1EE-AA44500953A6"),
				GenreId = 8
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				GenreId = 11
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("1F2E3281-95EA-4E2E-8693-D4983C7907DA"),
				GenreId = 12
			};

			movieGenres.Add(movieGenre);
			
			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("506F4021-595B-4637-BBA0-E2B88377549E"),
				GenreId = 8
			};

			movieGenres.Add(movieGenre);
			
			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),
				GenreId = 1
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("3D777BDC-DED7-42D2-B0A6-FC378EB32173"),
				GenreId = 5
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
				GenreId = 3
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
				GenreId = 6
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("E054427D-CA00-4BFC-921E-AE86FBF621EF"),
				GenreId = 13
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
				GenreId = 1
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
				GenreId = 5
			};

			movieGenres.Add(movieGenre);

			movieGenre = new MovieGenre()
			{
				MovieId = Guid.Parse("75CC9CFD-225C-4F69-8870-3986E74A88A4"),
				GenreId = 11
			};

			movieGenres.Add(movieGenre);

			return movieGenres.ToArray();

		}
	}
}
