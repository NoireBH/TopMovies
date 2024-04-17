namespace TopMovies.Web.ViewModels.Movies
{
	public class MoviesFilteredViewModel
	{
		public MoviesFilteredViewModel()
		{
			Movies = new HashSet<MovieViewModel>();
		}

		public int TotalMoviesCount { get; set; }

		public IEnumerable<MovieViewModel> Movies { get; set; }
	}
}
