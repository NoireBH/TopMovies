using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopMovies.Data.Models;

namespace TopMovies.Data.Configurations
{
	public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			builder.HasData(SeedUsers());
		}

		private  ApplicationUser[] SeedUsers()
		{

			var users = new HashSet<ApplicationUser>();

			string password = "123456";

			ApplicationUser user;
			PasswordHasher<ApplicationUser> passwordHasher;
			string hashed;

			user = new ApplicationUser()
			{
				Id = new Guid("E11F771C-1B10-41EB-81BC-0683DD00B080"),
				UserName = "firstUser",
				NormalizedUserName = "FIRSTUSER",
				Email = "FirstUser@abv.bg",
				NormalizedEmail = "FIRSTUSER@ABV.BG",
				EmailConfirmed = true,
				SecurityStamp = "BF648745-8661-43F4-8173-9EA6EB66931F"
            };

			passwordHasher = new PasswordHasher<ApplicationUser>();
			hashed = passwordHasher.HashPassword(user, password);
			user.PasswordHash = hashed;

			users.Add(user);

			user = new ApplicationUser()
			{
				Id = new Guid("2110C067-48D9-441A-A1EB-C723466B60C0"),
				UserName = "secondtUser",
				NormalizedUserName = "SECONDUSER",
				Email = "SecondUser@abv.bg",
				NormalizedEmail = "SECONDUSER@ABV.BG",
				EmailConfirmed = true,
                SecurityStamp = "96476EAD-3160-42A5-9116-294DF4E849D2"
            };

			passwordHasher = new PasswordHasher<ApplicationUser>();
			hashed = passwordHasher.HashPassword(user, password);
			user.PasswordHash = hashed;

			users.Add(user);

			user = new ApplicationUser()
			{
				Id = new Guid("129D8177-95E3-404F-872E-EB94FE803BD1"),
				UserName = "admin",
				NormalizedUserName = "ADMIN",
				Email = "admin_topmovies@gmail.com",
				NormalizedEmail = "ADMIN_TOPMOVIES@GMAIL.COM",
				EmailConfirmed = true,
                SecurityStamp = "DE313F5D-BCF1-43F0-8115-8FC46B08522C"
            };

			passwordHasher = new PasswordHasher<ApplicationUser>();
			hashed = passwordHasher.HashPassword(user, password);
			user.PasswordHash = hashed;

			users.Add(user);

			return users.ToArray();
		}
	}
}
