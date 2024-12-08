using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Group4FullSD.Data
{
    public class Group4FullSDContext : IdentityDbContext<Group4FullSDUser>
    {
        public Group4FullSDContext(DbContextOptions<Group4FullSDContext> options)
            : base(options)
        {
        }

    }
}

