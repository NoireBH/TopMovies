﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieAllQueryModel
	{
        public MovieAllQueryModel()
        {
			CurrentPage = DefaultPage;
			Genres = new HashSet<string>();
			Movies = new HashSet<MovieViewModel>();
		}

        public string? Category { get; set; }

		[DisplayName("Search by text")]
		public string? SearchTerm { get; set; }

		[DisplayName("Sort houses by")]
		public HouseSort HouseSorting { get; set; }

		public int CurrentPage { get; set; }

		public int TotalMoviesCount { get; set; }

		public IEnumerable<string> Genres { get; set; }

		public IEnumerable<MovieViewModel> Movies { get; set; }
	}
}