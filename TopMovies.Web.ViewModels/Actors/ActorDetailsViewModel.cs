﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;
using TopMovies.Web.ViewModels.MovieCharacters;
using TopMovies.Web.ViewModels.Movies;

namespace TopMovies.Web.ViewModels.Actors
{
	public class ActorDetailsViewModel : IMapFrom<Actor>, IHaveCustomMappings
	{
        public ActorDetailsViewModel()
        {
			Movies = new HashSet<ActorMoviesViewModel>();
		}

        public int Id { get; set; }

		public string Name { get; set; } = null!;

		public string Description { get; set; } = null!;

		public string ImageUrl { get; set; } = null!;

		public string DateOfBirth { get; set; } = null!;

		public IEnumerable<ActorMoviesViewModel> Movies { get; set; } = null!;

		public void CreateMappings(IProfileExpression configuration)
		{
			configuration.CreateMap<Actor, ActorDetailsViewModel>()
			   .ForMember(m => m.DateOfBirth, cfg => cfg
				   .MapFrom(m => m.DateOfBirth.ToString("yyyy-MM-dd")));
		}
	}
}
