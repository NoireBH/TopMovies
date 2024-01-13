using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TopMovies.Data
{
	public class TopMoviesDbContext : IdentityDbContext
	{
		public TopMoviesDbContext(DbContextOptions<TopMoviesDbContext> options)
			: base(options)
		{

		}
	}
}