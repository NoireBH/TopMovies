using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
	public class Photo
	{
        public Photo()
        {
			MoviePhotos = new HashSet<MoviePhoto>();

		}

        public int Id { get; set; }

		public string ImageURl { get; set; } = null!;

		public virtual ICollection<MoviePhoto> MoviePhotos { get; set; } = null!;
	}
}
