using TopMovies.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TopMovies.Data
{
	public class TopMoviesDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{

		public DbSet<Actor> Actors { get; set; }

		public DbSet<Genre> Genres {  get; set; }
		
		public DbSet<Movie> Movies { get; set; }

		public DbSet<MovieCharacter> MovieCharacters { get; set; }

		public DbSet<UserReview> UserReviews { get; set; }
		public TopMoviesDbContext(DbContextOptions<TopMoviesDbContext> options)
			: base(options)
		{

		}
	}
}