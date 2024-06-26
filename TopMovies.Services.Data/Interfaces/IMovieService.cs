﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Web.ViewModels.Home;
using TopMovies.Web.ViewModels.Movies;
using TopMovies.Web.ViewModels.Page;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IMovieService
	{
		Task<MoviesFilteredViewModel> GetAllMoviesAsync(MoviePageViewModel model);

		Task<MovieViewModel[]> GetAllMoviesBySearchAsync(MovieSearchFormModel model);

		Task<FeaturedMoviesViewModel[]> GetFeaturedMoviesAsync();

		Task<bool> ExistsByIdAsync(string  id);
		Task<bool> ExistsByNameAndReleaseDate(string name, int year, int month, int day);

		Task<MovieDetailsViewModel> GetMovieDetailsByIdAsync(string id);

		Task<MovieActorsAndCharactersViewModel[]> GetMovieActorsAndCharactersByMovieIdAsync(string id);

		Task<int> GetMovieCountAsync();

		Task AddMovieAsync(MovieAddOrEditFormModel movie);

		Task DeleteAsync(string id);

		Task EditMovie(MovieAddOrEditFormModel model);

		Task<MovieAllViewModel[]> GetMoviesBySearchTerm(string searchTerm);
	}
}
