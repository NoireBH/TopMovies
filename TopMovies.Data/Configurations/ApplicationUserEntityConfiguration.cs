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
	public class ApplicationUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		private readonly TopMoviesDbContext context;

		public ApplicationUserEntityConfiguration(TopMoviesDbContext context)
        {
			this.context = context;
        }

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			throw new NotImplementedException();
		}

		private ApplicationUser[] SeedUsers()
		{
			throw new NotImplementedException();

			var users = new HashSet<ApplicationUser>();

			var user = new ApplicationUser()
			{
				Id = Guid.Parse("E11F771C-1B10-41EB-81BC-0683DD00B080"),

			};
		}
	}
}
