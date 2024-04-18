using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using TopMovies.Data;
using TopMovies.Data.Models;
using TopMovies.Services.Data.Interfaces;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Home;
using TopMovies.Web.ViewModels.Movies;
using TopMovies.Web.ViewModels.Page;

namespace TopMovies.Services.Data
{
	public class MovieService : IMovieService
    {
        private readonly TopMoviesDbContext context;

        public MovieService(TopMoviesDbContext context)
        {
            this.context = context;
        }

		public async Task AddMovieAsync(MovieAddOrEditFormModel movie)
		{
            Movie newMovie = new Movie()
            {
                Id = movie.Id,
                Name = movie.Name,
                Description = movie.Description,
                ReleaseDate = movie.ReleaseDate,
                ImageUrl = movie.ImageUrl,
                TrailerUrl = movie.TrailerUrl.Replace("watch?v=", "embed/")
            };

            await context.Movies.AddAsync(newMovie);
            await context.SaveChangesAsync();
		}

		public async Task DeleteAsync(string movieId)
		{
			var movie = await context.Movies.FirstOrDefaultAsync(h => h.Id.ToString() == movieId);
			var movieCharacters = context.MovieCharacters.Where(mc => mc.MovieId.ToString() == movieId);
			context.MovieCharacters.RemoveRange(movieCharacters);
			context.Movies.Remove(movie!);
			await context.SaveChangesAsync();

		}

		public async Task EditMovie(MovieAddOrEditFormModel model)
		{
			var movie = await context.Movies.FirstAsync(h => h.Id.ToString() == model.Id.ToString());

			movie.Name = model.Name;
			movie.Description = model.Description;
			movie.ImageUrl = model.ImageUrl;
			movie.TrailerUrl = model.TrailerUrl.Replace("watch?v=", "embed");
			movie.ReleaseDate = model.ReleaseDate;

			await context.SaveChangesAsync();
		}	

		public async Task<bool> ExistsByIdAsync(string id)
        {
            return await context.Movies.AnyAsync(m => m.Id.ToString() == id);
        }

		public async Task<bool> ExistsByNameAndReleaseDate(string name, int year, int month, int day)
		{
			return await context.Movies
                .AnyAsync(m => m.Name == name && 
                m.ReleaseDate.Year == year && 
                m.ReleaseDate.Month == month &&
                m.ReleaseDate.Day == day);
		}

		public async Task<MoviesFilteredViewModel> GetAllMoviesAsync(MoviePageViewModel model)
		{
			var moviesQuery =  context.Movies
				.AsQueryable();


			var movies =  await moviesQuery
				.Skip((model.CurrentPage - 1) * model.ItemsPerPage)
				.Take(model.ItemsPerPage)
				.To<MovieViewModel>()
                .ToArrayAsync();

            int totalItems = moviesQuery.Count();

			return new MoviesFilteredViewModel()
			{
				TotalMoviesCount = totalItems,
				Movies = movies
			};
		}

		public async Task<FeaturedMoviesViewModel[]> GetFeaturedMoviesAsync()
        {
            Movie[] allMovies = await context.Movies.AsNoTracking().OrderBy(_ => Guid.NewGuid()).Take(3).ToArrayAsync();

            FeaturedMoviesViewModel[] featuredMovies = allMovies
                .Select(m => new FeaturedMoviesViewModel
                {
                    Id = m.Id.ToString(),
                    Name = m.Name,
                    ImageUrl = m.ImageUrl
                }).ToArray();

            return featuredMovies;
        }

		public async Task<MovieActorsAndCharactersViewModel[]> GetMovieActorsAndCharactersByMovieIdAsync(string id)
		{
            var movieActorsAndCharacters = await context.MovieCharacters
                .Where(mc => mc.MovieId.ToString() == id)
				.To<MovieActorsAndCharactersViewModel>()
				.ToArrayAsync();

            return movieActorsAndCharacters!;
		}

		public async Task<MovieAllViewModel[]> GetMoviesBySearchTerm(string searchTerm)
		{
            var movies = await context.Movies
                .Where(m => m.Name.ToLower().Contains(searchTerm.ToLower()) ||
                        m.Description.ToLower().Contains(searchTerm.ToLower()) ||
                        m.ActorsMovies.Any(am => am.Actor.Name.ToLower().Contains(searchTerm.ToLower())))
                .To<MovieAllViewModel>()
                .ToArrayAsync();

            return movies;
		}

		public async Task<int> GetMovieCountAsync()
		{
			return await context.Movies.CountAsync();
		}

		public async Task<MovieDetailsViewModel> GetMovieDetailsByIdAsync(string id)
        {
            var movie = await context.Movies
                .Where(m => m.Id.ToString().ToLower() == id.ToLower())
                .To<MovieDetailsViewModel>()
                .FirstOrDefaultAsync();

            return movie!;

        }

		public async Task<MovieViewModel[]> GetAllMoviesBySearchAsync(MovieSearchFormModel model)
		{
			var movies = await context.Movies
			.Where(m =>
                        m.Name.ToLower().Contains(model.SearchTeam.ToLower()) ||
                        m.Description.ToLower().Contains(model.SearchTeam.ToLower()))
			.To<MovieViewModel>()
				.ToArrayAsync();

            return movies;
		}
	}
}
