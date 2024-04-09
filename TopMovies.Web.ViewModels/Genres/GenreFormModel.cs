using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.Genres
{
	public class GenreFormModel : IMapFrom<Genre>
	{
		public int Id { get; set; }

		public string Name { get; set; } = null!;
	}
}
