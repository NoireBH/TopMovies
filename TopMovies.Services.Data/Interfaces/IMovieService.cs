﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Web.ViewModels.Home;
using TopMovies.Web.ViewModels.Movies;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IMovieService
	{
		Task<FeaturedMoviesViewModel[]> GetFeaturedMoviesAsync();

		Task<bool> ExistsByIdAsync(string  id);
		Task<bool> ExistsByNameAndReleaseDate(string name, string year, string month, string day);

		Task<MovieDetailsViewModel> GetMovieDetailsByIdAsync(string id);

		Task<MovieActorsAndCharactersViewModel[]> GetMovieActorsAndCharactersByMovieIdAsync(string id);

		Task<int> GetMovieCountAsync();

		Task AddMovieAsync(MovieAddOrEditFormModel movie);
	}
}
