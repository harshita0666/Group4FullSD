using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class LocationSeed : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new Location
                {
                    Id = 1,
                    Name = "Downtown Animal Shelter",
                    Address = "123 Main Street, Downtown",
                    Contact_Number = "123-456-7890",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Location
                {
                    Id = 2,
                    Name = "Uptown Animal Shelter",
                    Address = "456 Uptown Avenue, Uptown",
                    Contact_Number = "987-654-3210",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Location
                {
                    Id = 3,
                    Name = "Suburban Animal Shelter",
                    Address = "789 Suburban Road, Suburbia",
                    Contact_Number = "555-555-5555",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

