using Group4FullSD.Data;
using Microsoft.AspNetCore.Identity;

namespace Group4FullSD.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<Group4FullSDUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<Group4FullSDUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
