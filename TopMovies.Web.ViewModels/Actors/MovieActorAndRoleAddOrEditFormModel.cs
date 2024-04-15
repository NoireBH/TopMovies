using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TopMovies.Common;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;
using static TopMovies.Common.EntityValidationConstants.Actor;
using static TopMovies.Common.EntityValidationConstants.MovieCharacter;

namespace TopMovies.Web.ViewModels.Actors
{
	public class MovieActorAndRoleAddOrEditFormModel : IMapFrom<ActorMovie>, IMapFrom<MovieCharacter>
	{
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
		[StringLength(EntityValidationConstants.MovieCharacter.NameMaxLength, MinimumLength = EntityValidationConstants.MovieCharacter.NameMinLength)]
		public string MovieCharacterName { get; set; } = null!;

		[Required]
		public string MovieCharacterImageUrl { get; set; } = null!;

		public int MovieCharacterAge { get; set; }

	}
}
