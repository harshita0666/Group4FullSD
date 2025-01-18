using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class AdopterSeed : IEntityTypeConfiguration<Adopter>
    {
        public void Configure(EntityTypeBuilder<Adopter> builder)
        {
            // Seed data for Adopters
            builder.HasData(
                new Adopter
                {
                    Id = 1,
                    Name = "John Doe",
                    Email = "johndoe@example.com",
                    Phone_Number = "1234567890",
                    Address = "123 Maple Street, Springfield",
                    Date_Of_Birth = new DateTime(1990, 5, 15),
                    Adoption_History = "Adopted 2 pets in the past",
                    Registration_Date = new DateTime(2022, 3, 1),
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Adopter
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Email = "janesmith@example.com",
                    Phone_Number = "9876543210",
                    Address = "456 Oak Avenue, Metropolis",
                    Date_Of_Birth = new DateTime(1985, 10, 22),
                    Adoption_History = "First-time adopter",
                    Registration_Date = new DateTime(2023, 1, 10),
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Adopter
                {
                    Id = 3,
                    Name = "Alice Johnson",
                    Email = "alicejohnson@example.com",
                    Phone_Number = "1122334455",
                    Address = "789 Pine Road, Gotham",
                    Date_Of_Birth = new DateTime(1995, 7, 30),
                    Adoption_History = "Adopted 1 pet last year",
                    Registration_Date = new DateTime(2023, 5, 25),
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

