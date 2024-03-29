﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;

namespace TopMovies.Data.Configurations
{
	public class GenreEntityConfiguration : IEntityTypeConfiguration<Genre>
	{
		public void Configure(EntityTypeBuilder<Genre> builder)
		{
			builder.HasData(SeedGenres());
		}

		private Genre[] SeedGenres()
		{
			var genres = new HashSet<Genre>();

			Genre genre;

			genre = new Genre()
			{
				Id = 1,
				Name = "Action"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 2,
				Name = "Animation"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 3,
				Name = "Comedy"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 4,
				Name = "Crime"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 5,
				Name = "Drama"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 6,
				Name = "Fantasy"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 7,
				Name = "Sci-Fi"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 8,
				Name = "Horror"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 9,
				Name = "Romance"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 10,
				Name = "History"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 11,
				Name = "Mystery"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 12,
				Name = "Thriller"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 13,
				Name = "Adventure"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 14,
				Name = "Documentary"
			};

			genres.Add(genre);

			genre = new Genre()
			{
				Id = 15,
				Name = "Musical"
			};

			genres.Add(genre);

			return genres.ToArray();
		}
			
	}
}
