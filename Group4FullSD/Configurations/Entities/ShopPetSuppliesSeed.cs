using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class ShopPetSuppliesSeed : IEntityTypeConfiguration<ShopPetSupplies>
    {
        public void Configure(EntityTypeBuilder<ShopPetSupplies> builder)
        {
            builder.HasData(
                new ShopPetSupplies
                {
                    Id = 1,
                    Name = "Dog Food - Premium",
                    Category = "Food",
                    Pricing = 50.00,
                    Quantity = 100,
                    Location_ID = 1, // Reference to an existing Location with ID 1
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new ShopPetSupplies
                {
                    Id = 2,
                    Name = "Cat Toy - Feather Wand",
                    Category = "Toys",
                    Pricing = 15.00,
                    Quantity = 50,
                    Location_ID = 2, // Reference to an existing Location with ID 2
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new ShopPetSupplies
                {
                    Id = 3,
                    Name = "Aquarium Filter",
                    Category = "Accessories",
                    Pricing = 75.00,
                    Quantity = 25,
                    Location_ID = 3, // Reference to an existing Location with ID 3
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

