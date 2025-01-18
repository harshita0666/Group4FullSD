using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class OrderSeed : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                new Order
                {
                    Id = 1,
                    Adopter_ID = 1, // Reference to an existing Adopter with ID 1
                    Supply_ID = 1,  // Reference to an existing Supply with ID 1
                    Staff_ID = 1,   // Reference to an existing Staff with ID 1
                    Order_Date = new DateTime(2023, 6, 15),
                    Total_Price = 50.00,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Order
                {
                    Id = 2,
                    Adopter_ID = 2, // Reference to an existing Adopter with ID 2
                    Supply_ID = 2,  // Reference to an existing Supply with ID 2
                    Staff_ID = 2,   // Reference to an existing Staff with ID 2
                    Order_Date = new DateTime(2023, 7, 10),
                    Total_Price = 75.50,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Order
                {
                    Id = 3,
                    Adopter_ID = 3, // Reference to an existing Adopter with ID 3
                    Supply_ID = 3,  // Reference to an existing Supply with ID 3
                    Staff_ID = 3,   // Reference to an existing Staff with ID 3
                    Order_Date = new DateTime(2023, 8, 5),
                    Total_Price = 100.00,
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

