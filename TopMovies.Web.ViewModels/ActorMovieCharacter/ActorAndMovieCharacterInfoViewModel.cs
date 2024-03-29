﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Web.ViewModels.ActorMovieCharacter
{
	public class ActorAndMovieCharacterInfoViewModel
	{
		public int ActorId { get; set; }

		public string ActorName { get; set; } = null!;

		public string ActorImageUrl { get; set; } = null!;

		public int MovieCharacterId { get; set; }

		public string MovieCharacterName { get; set; } = null!;

		public string MovieCharacterImageUrl { get; set; } = null!;
	}
}
