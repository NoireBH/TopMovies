using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;

namespace TopMovies.Data.Configurations
{
	public class ActorMovieCharacterEntityConfiguration : IEntityTypeConfiguration<ActorMovieCharacter>
	{
		public void Configure(EntityTypeBuilder<ActorMovieCharacter> builder)
		{
			builder.HasData(SeedActorMovieCharacters());
		}

		private ActorMovieCharacter[] SeedActorMovieCharacters()
		{
			var actorMovieCharacters = new HashSet<ActorMovieCharacter>();

			ActorMovieCharacter actorMovieCharacter;

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 1,
				MovieCharacterId = 2,
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 2,
				MovieCharacterId = 1
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 3,
				MovieCharacterId = 3
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 4,
				MovieCharacterId = 5
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 5,
				MovieCharacterId = 6
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 6,
				MovieCharacterId = 4
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 7,
				MovieCharacterId = 7
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 8,
				MovieCharacterId = 8
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 9,
				MovieCharacterId = 9
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 10,
				MovieCharacterId = 10
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 11,
				MovieCharacterId = 11
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 12,
				MovieCharacterId = 12
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 13,
				MovieCharacterId = 13
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 14,
				MovieCharacterId = 14
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 15,
				MovieCharacterId = 16
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 16,
				MovieCharacterId = 17
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 17,
				MovieCharacterId = 18
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 18,
				MovieCharacterId = 19
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 19,
				MovieCharacterId = 20
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 20,
				MovieCharacterId = 21
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 21,
				MovieCharacterId = 22
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 22,
				MovieCharacterId = 23
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 23,
				MovieCharacterId = 24
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 24,
				MovieCharacterId = 25
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 21,
				MovieCharacterId = 26
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 25,
				MovieCharacterId = 27
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 26,
				MovieCharacterId = 29
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 21,
				MovieCharacterId = 28
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 27,
				MovieCharacterId = 30
			};

			actorMovieCharacters.Add(actorMovieCharacter);

			actorMovieCharacter = new ActorMovieCharacter()
			{
				ActorId = 28,
				MovieCharacterId = 15
			};

			actorMovieCharacters.Add(actorMovieCharacter);


			return actorMovieCharacters.ToArray();
		}

	}
}
