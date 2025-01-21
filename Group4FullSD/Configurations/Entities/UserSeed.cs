﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Group4FullSD.Data;

namespace Group4FullSD.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<Group4FullSDUser>
    {
        public void Configure(EntityTypeBuilder<Group4FullSDUser> builder)
        {
            var hasher = new PasswordHasher<Group4FullSDUser>();
            builder.HasData(
            new Group4FullSDUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}
