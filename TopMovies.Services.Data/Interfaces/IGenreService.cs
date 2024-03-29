﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Web.ViewModels.MoviesGenres;

namespace TopMovies.Services.Data.Interfaces
{
	public interface IGenreService
	{
		Task<MovieGenreViewModel[]> GetAllGenresAsync();

		Task<MovieGenreViewModel[]> GetMovieGenresByMovieIdAsync(string id);
	}
}
