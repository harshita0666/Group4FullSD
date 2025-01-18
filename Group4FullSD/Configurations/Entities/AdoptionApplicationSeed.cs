using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class AdoptionApplicationSeed : IEntityTypeConfiguration<AdoptionApplication>
    {
        public void Configure(EntityTypeBuilder<AdoptionApplication> builder)
        {
            builder.HasData(
                new AdoptionApplication
                {
                    Id = 1,
                    Adopter_ID = 1, // Corresponding to an existing Adopter with ID 1
                    Pet_ID = 1,     // Corresponding to an existing Pet with ID 1
                    Application_Status = "Approved",
                    Submission_Date = new DateTime(2023, 6, 15),
                    Approval_Date = new DateTime(2023, 6, 20),
                    Staff_Reviewed_By = 1, // Corresponding to an existing Staff with ID 1
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AdoptionApplication
                {
                    Id = 2,
                    Adopter_ID = 2, // Corresponding to an existing Adopter with ID 2
                    Pet_ID = 2,     // Corresponding to an existing Pet with ID 2
                    Application_Status = "Pending",
                    Submission_Date = new DateTime(2023, 7, 10),
                    Approval_Date = DateTime.MinValue, // Pending applications may not have approval dates
                    Staff_Reviewed_By = 2, // Corresponding to an existing Staff with ID 2
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AdoptionApplication
                {
                    Id = 3,
                    Adopter_ID = 3, // Corresponding to an existing Adopter with ID 3
                    Pet_ID = 3,     // Corresponding to an existing Pet with ID 3
                    Application_Status = "Rejected",
                    Submission_Date = new DateTime(2023, 8, 5),
                    Approval_Date = DateTime.MinValue, // Rejected applications may not have approval dates
                    Staff_Reviewed_By = 3, // Corresponding to an existing Staff with ID 3
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
