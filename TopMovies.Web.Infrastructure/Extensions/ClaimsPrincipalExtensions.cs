using System.Security.Claims;
using static TopMovies.Common.GeneralConstants.AdminUser;

namespace TopMovies.Web.Infrastructure.Extensions
{
	public static class ClaimsPrincipalExtensions
	{
		public static string? GetId(this ClaimsPrincipal user)
		{
			return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
		}

		public static bool IsAdmin(this ClaimsPrincipal user)
		{
			return user.IsInRole(AdminRoleName);
		}
	}
}
