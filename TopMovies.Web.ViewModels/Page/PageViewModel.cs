using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopMovies.Web.ViewModels.Page
{
	public class PageViewModel
	{
		public int CurrentPage { get; set; }

		public int ItemsPerPage { get; set; }

		public int TotalItemsCount { get; set; }
	}
}
