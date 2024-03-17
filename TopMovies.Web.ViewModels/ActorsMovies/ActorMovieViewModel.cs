using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.ActorsMovies
{
    public class ActorMovieViewModel : IMapFrom<ActorMovie>
    {
        public int ActorId { get; set; }

        public string MovieId { get; set; } = null!;

        public string ActorName { get; set; } = null!;

        public string ActorImageUrl { get; set; } = null!;
    }
}
