using TopMovies.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TopMovies.Data
{
	public class TopMoviesDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{

		public DbSet<Actor> Actors { get; set; } = null!;
		
		public DbSet<Movie> Movies { get; set; } = null!;

		public DbSet<MovieCharacter> MovieCharacters { get; set; } = null!;

		public DbSet<UserReview> UserReviews { get; set; } = null!;
		public TopMoviesDbContext(DbContextOptions<TopMoviesDbContext> options)
			: base(options)
		{

		}
	}
}