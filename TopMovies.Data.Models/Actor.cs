using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Data.Models
{
    public class Actor
    {
        public Actor()
        {
            Movies = new HashSet<Movie>();
        }

        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public byte[] Image { get; set; } = null!;

        public int Age { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
