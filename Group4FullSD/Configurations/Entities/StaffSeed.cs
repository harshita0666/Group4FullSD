using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class StaffSeed : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "john.doe@example.com",
                    Phone_Number = "123-456-7890",
                    Role = "Manager",
                    Join_Date = new DateTime(2020, 1, 15),
                    Location_ID = 1, // Reference to an existing Location with ID 1
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Email = "jane.smith@example.com",
                    Phone_Number = "987-654-3210",
                    Role = "Veterinarian",
                    Join_Date = new DateTime(2021, 6, 10),
                    Location_ID = 2, // Reference to an existing Location with ID 2
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Staff
                {
                    Id = 3,
                    Name = "Alice Johnson",
                    Email = "alice.johnson@example.com",
                    Phone_Number = "555-555-5555",
                    Role = "Adoption Coordinator",
                    Join_Date = new DateTime(2022, 3, 5),
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

