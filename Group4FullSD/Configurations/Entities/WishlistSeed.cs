using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class WishlistSeed : IEntityTypeConfiguration<Wishlist>
    {
        public void Configure(EntityTypeBuilder<Wishlist> builder)
        {
            builder.HasData(
                new Wishlist
                {
                    Id = 1,
                    Adopter_ID = 1, // Reference to an existing Adopter with ID 1
                    Pet_ID = 1,     // Reference to an existing Pet with ID 1
                    Added_Date = new DateTime(2023, 5, 15),
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Wishlist
                {
                    Id = 2,
                    Adopter_ID = 2, // Reference to an existing Adopter with ID 2
                    Pet_ID = 2,     // Reference to an existing Pet with ID 2
                    Added_Date = new DateTime(2023, 6, 10),
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Wishlist
                {
                    Id = 3,
                    Adopter_ID = 3, // Reference to an existing Adopter with ID 3
                    Pet_ID = 3,     // Reference to an existing Pet with ID 3
                    Added_Date = new DateTime(2023, 7, 5),
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

