using AutoMapper;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieAllViewModel : IMapFrom<Movie>
	{
		public Guid Id { get; set; }

		public string Name { get; set; } = null!;

		public string ImageUrl { get; set; } = null!;

		public string YearOfRelease { get; set; } = null!;

		public int CurrentPage { get; set; }

		public int TotalMoviesCount { get; set; }

		public void CreateMappings(IProfileExpression configuration)
		{
			configuration.CreateMap<Movie, MovieViewModel>()
			   .ForMember(m => m.YearOfRelease, cfg => cfg
				   .MapFrom(m => m.ReleaseDate.Year));
		}
	}
}
