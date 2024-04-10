using AutoMapper;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieViewModel : IMapFrom<Movie>, IHaveCustomMappings
	{
		public Guid Id { get; set; }

		public string Name { get; set; } = null!;

		public string ImageUrl { get; set; } = null!;

		public string YearOfRelease { get; set; } = null!;

		public void CreateMappings(IProfileExpression configuration)
		{
			configuration.CreateMap<Movie, MovieDetailsViewModel>()
			   .ForMember(m => m.ReleaseDateYear, cfg => cfg
				   .MapFrom(m => m.ReleaseDate.Year));
		}
	}
}
