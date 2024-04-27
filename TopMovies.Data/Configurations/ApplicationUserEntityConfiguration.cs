using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TopMovies.Data.Models;

namespace TopMovies.Data.Configurations
{
	public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		private readonly UserManager<ApplicationUser> userManager;

		public ApplicationUserEntityConfiguration(UserManager<ApplicationUser> userManager)
		{
			this.userManager = userManager;
		}

		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			builder.HasData(SeedUsers());
		}

		private async Task<ApplicationUser[]> SeedUsers()
		{

			var users = new HashSet<ApplicationUser>();

			string password = "123456";

			ApplicationUser user;
			PasswordHasher<ApplicationUser> passwordHasher;
			string hashed;

			user = new ApplicationUser()
			{
				Id = Guid.Parse("E11F771C-1B10-41EB-81BC-0683DD00B080"),
				UserName = "firstUser",
				NormalizedUserName = "FIRSTUSER",
				Email = "FirstUser@abv.bg",
				NormalizedEmail = "FIRSTUSER@ABV.BG",
				EmailConfirmed = true,
			};

			passwordHasher = new PasswordHasher<ApplicationUser>();
			hashed = passwordHasher.HashPassword(user, password);
			user.PasswordHash = hashed;

			var result = await userManager.CreateAsync(user, password);
			users.Add(user);

			user = new ApplicationUser()
			{
				Id = Guid.Parse("2110C067-48D9-441A-A1EB-C723466B60C0"),
				UserName = "secondtUser",
				NormalizedUserName = "SECONDUSER",
				Email = "SecondUser@abv.bg",
				NormalizedEmail = "SECONDUSER@ABV.BG",
				EmailConfirmed = true,
			};

			passwordHasher = new PasswordHasher<ApplicationUser>();
			hashed = passwordHasher.HashPassword(user, password);
			user.PasswordHash = hashed;

			var result2 = await userManager.CreateAsync(user, password);
			users.Add(user);

			user = new ApplicationUser()
			{
				Id = Guid.Parse("129D8177-95E3-404F-872E-EB94FE803BD1"),
				UserName = "thirdUser",
				NormalizedUserName = "THIRDUSER",
				Email = "ThirdUser@abv.bg",
				NormalizedEmail = "THIRDUSER@ABV.BG",
				EmailConfirmed = true,
			};

			passwordHasher = new PasswordHasher<ApplicationUser>();
			hashed = passwordHasher.HashPassword(user, password);
			user.PasswordHash = hashed;

			var result3 = await userManager.CreateAsync(user, password);
			users.Add(user);

			return users.ToArray();
		}
	}
}
