using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;

namespace TopMovies.Data.Configurations
{
    public class MovieEntityConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            throw new NotImplementedException();
        }

        private Movie[] SeedMovies()
        {
            var movies = new HashSet<Movie>();

            Movie movie;

            movie = new Movie()
            {

            };
        }
    }
}
