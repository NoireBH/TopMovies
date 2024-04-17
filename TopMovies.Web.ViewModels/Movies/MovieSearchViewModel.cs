using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieSearchViewModel
	{
		public string MovieId { get; set; } = null!;

		[Required]
		public string SearchedTerm { get; set; } = null!;
	}
}
