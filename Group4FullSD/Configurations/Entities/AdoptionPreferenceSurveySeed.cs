using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class AdoptionPreferenceSurveySeed : IEntityTypeConfiguration<AdoptionPreferenceSurvey>
    {
        public void Configure(EntityTypeBuilder<AdoptionPreferenceSurvey> builder)
        {
            builder.HasData(
                new AdoptionPreferenceSurvey
                {
                    Id = 1,
                    Adopter_ID = 1, // Corresponding to an existing Adopter with ID 1
                    Pet_ID = 1,     // Corresponding to an existing Pet with ID 1
                    Question = "What type of pet are you looking for?",
                    Answer = "Small-sized, friendly dog suitable for an apartment.",
                    Submission_Date = new DateTime(2023, 6, 15),
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AdoptionPreferenceSurvey
                {
                    Id = 2,
                    Adopter_ID = 2, // Corresponding to an existing Adopter with ID 2
                    Pet_ID = 2,     // Corresponding to an existing Pet with ID 2
                    Question = "Do you have any preferences for the pet's behavior or training?",
                    Answer = "Prefer a playful and energetic cat.",
                    Submission_Date = new DateTime(2023, 7, 20),
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new AdoptionPreferenceSurvey
                {
                    Id = 3,
                    Adopter_ID = 3, // Corresponding to an existing Adopter with ID 3
                    Pet_ID = 3,     // Corresponding to an existing Pet with ID 3
                    Question = "Are there any specific characteristics you prefer?",
                    Answer = "Medium-sized dog with good health and obedience training.",
                    Submission_Date = new DateTime(2023, 8, 5),
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
