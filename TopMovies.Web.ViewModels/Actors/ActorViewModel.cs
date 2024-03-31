using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.Actors
{
	public class ActorViewModel : IMapFrom<ActorMovie>
    {
        public int ActorId { get; set; }

        public string ActorName { get; set; } = null!;

        public string ActorImageUrl { get; set; } = null!;
    }
}
