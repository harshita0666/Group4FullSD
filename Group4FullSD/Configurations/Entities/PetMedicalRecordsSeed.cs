using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class PetMedicalRecordsSeed : IEntityTypeConfiguration<PetMedicalRecords>
    {
        public void Configure(EntityTypeBuilder<PetMedicalRecords> builder)
        {
            builder.HasData(
                new PetMedicalRecords
                {
                    Id = 1,
                    Pet_ID = 1, // Reference to an existing Pet with ID 1
                    Vaccination_Status = "Up-to-date",
                    Medical_Conditions = "None",
                    Last_Checkup_Date = new DateTime(2023, 6, 1),
                    Medical_History = "Routine vaccinations completed, no major issues.",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new PetMedicalRecords
                {
                    Id = 2,
                    Pet_ID = 2, // Reference to an existing Pet with ID 2
                    Vaccination_Status = "Up-to-date",
                    Medical_Conditions = "Allergies to certain foods",
                    Last_Checkup_Date = new DateTime(2023, 5, 15),
                    Medical_History = "Routine checkups show minor food allergies.",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new PetMedicalRecords
                {
                    Id = 3,
                    Pet_ID = 3, // Reference to an existing Pet with ID 3
                    Vaccination_Status = "Up-to-date",
                    Medical_Conditions = "None",
                    Last_Checkup_Date = new DateTime(2023, 7, 10),
                    Medical_History = "All vaccinations completed, healthy overall.",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

