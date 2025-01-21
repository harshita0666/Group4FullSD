using Microsoft.AspNetCore.Identity;

namespace Group4FullSD.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Group4FullSDUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
