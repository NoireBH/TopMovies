using AutoMapper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TopMovies.Common;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.Movies;
using static TopMovies.Common.EntityValidationConstants.Actor;
using static TopMovies.Common.EntityValidationConstants.MovieCharacter;

namespace TopMovies.Web.ViewModels.Actors
{
	public class MovieActorAndRoleAddOrEditFormModel : IMapFrom<ActorMovie>, IMapFrom<MovieCharacter>, IHaveCustomMappings
	{
		public int ActorId {  get; set; }

		public string MovieId { get; set; } = null!;

		[Required]
		[StringLength(EntityValidationConstants.Actor.NameMaxLength, MinimumLength = EntityValidationConstants.Actor.NameMinLength)]
		[Display(Name = "Name")]
		public string ActorName { get; set; } = null!;

		[Required]
		[StringLength(EntityValidationConstants.Actor.DescriptionMaxLength, MinimumLength = EntityValidationConstants.Actor.DescriptionMinLength)]
		[Display(Name = "Description")]
		public string ActorDescription { get; set; } = null!;

		[Required]
		[Display(Name = "Image Link")]
		public string ActorImageUrl { get; set; } = null!;

		[Required]
		[Display(Name = "Date of birth")]
		public DateTime ActorDateOfBirth { get; set; }

		[Required]
		[Display(Name = "Movie character name")]
		[StringLength(EntityValidationConstants.MovieCharacter.NameMaxLength, MinimumLength = EntityValidationConstants.MovieCharacter.NameMinLength)]
		public string MovieCharacterName { get; set; } = null!;

		[Required]
		[Display(Name = "Movie character image link")]
		public string MovieCharacterImageUrl { get; set; } = null!;

		[Display(Name = "Movie character age")]
		public int MovieCharacterAge { get; set; }

		public void CreateMappings(IProfileExpression configuration)
		{
			configuration.CreateMap<MovieCharacter, MovieActorAndRoleAddOrEditFormModel>()
			   .ForMember(m => m.MovieCharacterName, cfg => cfg
				   .MapFrom(m => m.Name))
			.ForMember(m => m.MovieCharacterAge, cfg => cfg
				   .MapFrom(m => m.Age))
			.ForMember(m => m.MovieCharacterImageUrl, cfg => cfg
				   .MapFrom(m => m.ImageUrl));
		}
	}
}
