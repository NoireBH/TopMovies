using TopMovies.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TopMovies.Data.Configurations;

namespace TopMovies.Data
{
	public class TopMoviesDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{

		public DbSet<Actor> Actors { get; set; } = null!;

		public DbSet<ActorMovie> ActorMovies { get; set; } = null!;

		public DbSet<ActorMovieCharacter> ActorMovieCharacters { get; set; } = null!;

		public DbSet<Movie> Movies { get; set; } = null!;

		public DbSet<MovieCharacter> MovieCharacters { get; set; } = null!;

		public DbSet<MovieGenre> MovieGenres { get; set; } = null!;

		public DbSet<MovieMovieCharacter> MovieMovieCharacters { get; set; } = null!;

		public DbSet<UserReview> UserReviews { get; set; } = null!;

		public DbSet<Genre> Genres { get; set; } = null!;

		public TopMoviesDbContext(DbContextOptions<TopMoviesDbContext> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new ActorEntityConfiguration());
			builder.ApplyConfiguration(new GenreEntityConfiguration());
			builder.ApplyConfiguration(new MovieEntityConfiguration());
			builder.ApplyConfiguration(new UserReviewEntityConfiguration());

			base.OnModelCreating(builder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
	}
}