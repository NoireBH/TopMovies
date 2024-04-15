using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Web.ViewModels.Genres;
using TopMovies.Web.ViewModels.MoviesGenres;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IGenreService
	{
		Task<GenreFormModel[]> GetAllGenresAsync();

		Task<MovieGenreViewModel[]> GetMovieGenresByMovieIdAsync(string id);

		Task AddGenreAsync(GenreAddOrEditFormModel model);

		Task AddGenreToMovieAsync(MovieGenreAddOrEditFormModel model, string movieId);

		Task<bool> ExistsByNameAsync(string name);

		Task<bool> ExistsByIdAsync(int id);

		Task<bool> MovieGenreExistsByGenreAndMovieId(int genreId, string movieId);
	}
}
