using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;

namespace TopMovies.Data.Configurations
{
	public class PhotoEntityConfiguration : IEntityTypeConfiguration<Photo>
	{
		public void Configure(EntityTypeBuilder<Photo> builder)
		{
			builder.HasData(SeedPhotos());
		}

		public Photo[] SeedPhotos()
		{
			var photos = new HashSet<Photo>();

			Photo photo;

			photo = new Photo()
			{
				Id = 1,
				ImageURl = "https://m.media-amazon.com/images/M/MV5BMTM0NjUxMDk5MF5BMl5BanBnXkFtZTcwNDMxNDY3Mw@@._V1_FMjpg_UX1800_.jpg",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD")
				
			};

			photos.Add(photo);

			photo = new Photo()
			{
				Id = 2,
				ImageURl = "https://m.media-amazon.com/images/M/MV5BMTM0NjUxMDk5MF5BMl5BanBnXkFtZTcwNDMxNDY3Mw@@._V1_FMjpg_UX1800_.jpg",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD")

			};

			photos.Add(photo);

			photo = new Photo()
			{
				Id = 3,
				ImageURl = "https://m.media-amazon.com/images/M/MV5BMTM0NjUxMDk5MF5BMl5BanBnXkFtZTcwNDMxNDY3Mw@@._V1_FMjpg_UX1800_.jpg",
				MovieId = Guid.Parse("2CA61990-FE17-483C-863D-442EE4C0ACAD")

			};

			photos.Add(photo);

			return photos.ToArray();
		}
	}

}
