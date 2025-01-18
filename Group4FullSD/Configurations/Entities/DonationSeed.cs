using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class DonationSeed : IEntityTypeConfiguration<Donation>
    {
        public void Configure(EntityTypeBuilder<Donation> builder)
        {
            builder.HasData(
                new Donation
                {
                    Id = 1,
                    Donor_ID = 1, // Corresponding to an existing Adopter with ID 1
                    Donation_Amount = 100.00,
                    Donation_Date = new DateTime(2023, 6, 15),
                    Location_ID = 1, // Corresponding to an existing Location with ID 1
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Donation
                {
                    Id = 2,
                    Donor_ID = 2, // Corresponding to an existing Adopter with ID 2
                    Donation_Amount = 200.00,
                    Donation_Date = new DateTime(2023, 7, 10),
                    Location_ID = 2, // Corresponding to an existing Location with ID 2
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Donation
                {
                    Id = 3,
                    Donor_ID = 3, // Corresponding to an existing Adopter with ID 3
                    Donation_Amount = 50.00,
                    Donation_Date = new DateTime(2023, 8, 5),
                    Location_ID = 3, // Corresponding to an existing Location with ID 3
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

