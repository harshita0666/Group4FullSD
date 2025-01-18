using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class CostSeed : IEntityTypeConfiguration<Cost>
    {
        public void Configure(EntityTypeBuilder<Cost> builder)
        {
            builder.HasData(
                new Cost
                {
                    Id = 1,
                    Adopter_ID = 1, // Reference to an existing Adopter with ID 1
                    Pet_ID = 1,     // Reference to an existing Pet with ID 1
                    Staff_Reviewed_By = 1, // Reference to an existing Staff with ID 1
                    Adoption_Cost = 150.00,
                    Adoption_Status = "Paid",
                    Submission_Date = new DateTime(2023, 5, 15),
                    Approval_Date = new DateTime(2023, 5, 20),
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Cost
                {
                    Id = 2,
                    Adopter_ID = 2, // Reference to an existing Adopter with ID 2
                    Pet_ID = 2,     // Reference to an existing Pet with ID 2
                    Staff_Reviewed_By = 2, // Reference to an existing Staff with ID 2
                    Adoption_Cost = 200.00,
                    Adoption_Status = "Pending",
                    Submission_Date = new DateTime(2023, 6, 10),
                    Approval_Date = null, // Pending applications may not have an approval date
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Cost
                {
                    Id = 3,
                    Adopter_ID = 3, // Reference to an existing Adopter with ID 3
                    Pet_ID = 3,     // Reference to an existing Pet with ID 3
                    Staff_Reviewed_By = 3, // Reference to an existing Staff with ID 3
                    Adoption_Cost = 120.00,
                    Adoption_Status = "Rejected",
                    Submission_Date = new DateTime(2023, 7, 5),
                    Approval_Date = null, // Rejected applications may not have an approval date
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

