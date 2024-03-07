using TopMovies.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TopMovies.Data.Configurations;
using Microsoft.Extensions.DependencyInjection;

namespace TopMovies.Data
{
	public class TopMoviesDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
	{

		public TopMoviesDbContext(DbContextOptions<TopMoviesDbContext> options)
			: base(options)
		{

		}

		public DbSet<Actor> Actors { get; set; } = null!;

		public DbSet<ActorMovie> ActorMovies { get; set; } = null!;

		public DbSet<ActorMovieCharacter> ActorMovieCharacters { get; set; } = null!;

		public DbSet<Movie> Movies { get; set; } = null!;

		public DbSet<MovieCharacter> MovieCharacters { get; set; } = null!;

		public DbSet<Quote> Quotes { get; set; } = null!;

		public DbSet<MovieGenre> MovieGenres { get; set; } = null!;

		public DbSet<MovieMovieCharacter> MovieMovieCharacters { get; set; } = null!;

		public DbSet<UserReview> UserReviews { get; set; } = null!;

		public DbSet<Genre> Genres { get; set; } = null!;

		public DbSet<Photo> Photos { get; set; } = null!;


		protected override void OnModelCreating(ModelBuilder builder)
		{

			builder.Entity<ActorMovie>().HasKey(x => new { x.MovieId, x.ActorId });
			builder.Entity<ActorMovieCharacter>().HasKey(x => new { x.MovieCharacterId, x.ActorId });
			builder.Entity<MovieMovieCharacter>().HasKey(x => new { x.MovieCharacterId, x.MovieId });
			builder.Entity<MovieGenre>().HasKey(x => new { x.GenreId, x.MovieId });

			//builder.ApplyConfiguration(new ApplicationUserEntityConfiguration());
			builder.ApplyConfiguration(new ActorEntityConfiguration());
			builder.ApplyConfiguration(new GenreEntityConfiguration());
			builder.ApplyConfiguration(new MovieEntityConfiguration());

			builder.ApplyConfiguration(new ActorMovieEntityConfiguration());
			builder.ApplyConfiguration(new MovieCharactersEntityConfiguration());
			builder.ApplyConfiguration(new MovieMovieCharacterEntityConfiguration());
			//builder.ApplyConfiguration(new UserReviewEntityConfiguration());



			base.OnModelCreating(builder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}
	}
}