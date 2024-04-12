using System.ComponentModel;
using TopMovies.Web.ViewModels.Movies.Enums;
using static TopMovies.Common.GeneralConstants.Page;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieAdvancedSearchQueryModel
	{
        public MovieAdvancedSearchQueryModel()
        {
			CurrentPage = DefaultPage;
			MoviesPerPage = DefaultMoviesPerPage;
			Genres = new HashSet<string>();
			Movies = new HashSet<MovieViewModel>();
		}

        public string? Genre { get; set; }

		[DisplayName("Search by title")]
		public string? SearchTerm { get; set; }

		[DisplayName("Sort movies by")]
		public MovieSort MovieSorting { get; set; }

		public int CurrentPage { get; set; }

		[DisplayName("Movies per page")]
		public int MoviesPerPage { get; set; }

		public int TotalMoviesCount { get; set; }

		public IEnumerable<string> Genres { get; set; }

		public IEnumerable<MovieViewModel> Movies { get; set; }
	}
}
