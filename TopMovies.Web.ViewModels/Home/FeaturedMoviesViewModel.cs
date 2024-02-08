using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Web.ViewModels.Home
{
    public class FeaturedMoviesViewModel
    {
        public string Id { get; set; } = null!;

        public string Title { get; set; } = null!;

        public string Image { get; set; } = null!;
    }
}
