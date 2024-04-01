using AutoMapper;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.Movies
{
	public class MovieActorsAndCharactersViewModel : IMapFrom<MovieCharacter>, IHaveCustomMappings
	{
		public int ActorId { get; set; }

		public string ActorName { get; set; } = null!;

		public string ActorImageUrl { get; set; } = null!;

		public int MovieCharacterId { get; set; }

		public string MovieCharacterName { get; set; } = null!;

		public void CreateMappings(IProfileExpression configuration)
		{
			configuration.CreateMap<MovieCharacter, MovieActorsAndCharactersViewModel>()
				.ForMember(mac => mac.MovieCharacterId, cgf => cgf
					.MapFrom(mc => mc.Id))
				.ForMember(mac => mac.MovieCharacterName, cgf => cgf
					.MapFrom(mc => mc.Name));
		}
	}
}
