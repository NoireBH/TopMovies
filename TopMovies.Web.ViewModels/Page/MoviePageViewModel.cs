using TopMovies.Web.ViewModels.Movies;
using static TopMovies.Common.GeneralConstants.Page;

namespace TopMovies.Web.ViewModels.Page
{
	public class MoviePageViewModel
	{
        public MoviePageViewModel()
        {
			CurrentPage = DefaultPage;
			ItemsPerPage = DefaultItemsPerPage;
			Movies = new HashSet<MovieViewModel>();

		}

        public int CurrentPage { get; set; }

		public int ItemsPerPage { get; set; }

		public int TotalItemsCount { get; set; }

		public IEnumerable<MovieViewModel> Movies { get; set; }
	}
}
