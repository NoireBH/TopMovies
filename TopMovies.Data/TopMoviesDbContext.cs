using TopMovies.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TopMovies.Data
{
	public class TopMoviesDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{
		public TopMoviesDbContext(DbContextOptions<TopMoviesDbContext> options)
			: base(options)
		{

		}
	}
}