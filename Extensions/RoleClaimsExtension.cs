using System.Security.Claims;
using Blog.Models;

namespace Blog.Extensions
{
    public static class RoleClaimsExtension
    {
        public static IEnumerable<Claim> GetClaims(this User user)
        {
            // Create list of claims, start adding the name only
            var result = new List<Claim>()
            {
                new (ClaimTypes.Name, user.Name)
            };

            // Add all roles of user
            result.AddRange(
                user.Roles.Select(role => new Claim(ClaimTypes.Role, role.Slug))
            );

            return result;
        }
    }
}
