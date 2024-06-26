﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Web.ViewModels.Genres;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieSearchFormModel
	{

        [Required]
		[Display(Name = "Search for movie by it's name or description of the plot")]
		public string SearchTeam { get; set; } = null!;

	}
}
