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

		public string Id { get; set; } = null!;

		public string ApplicationUserId { get; set; } = null!;

		public string MovieId { get; set; } = null!;

		public string ApplicationUserUserName { get; set; } = null!;

        public string Comment { get; set; } = null!;
    }
}
