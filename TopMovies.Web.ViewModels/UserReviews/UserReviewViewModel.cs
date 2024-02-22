using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopMovies.Data.Models;
using TopMovies.Services.Mapping;

namespace TopMovies.Web.ViewModels.UserReviews
{
    public class UserReviewViewModel : IMapFrom<UserReview>
    {
        public ApplicationUser ApplicationUserUserName { get; set; } = null!;

        public int Rating { get; set; }

        public string Comment { get; set; } = null!;
    }
}
