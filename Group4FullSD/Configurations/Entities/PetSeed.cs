using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class PetSeed : IEntityTypeConfiguration<Pet>
    {
        public void Configure(EntityTypeBuilder<Pet> builder)
        {
            builder.HasData(
                new Pet
                {
                    Id = 1,
                    Name = "Buddy",
                    Species = "Dog",
                    Gender = "Male",
                    Breed = "Golden Retriever",
                    Age = 3,
                    Size = "Large",
                    Adoption_Status = "Available",
                    Health_Status = "Healthy",
                    Personality_Traits = "Friendly, Playful",
                    Location_ID = 1, // Reference to an existing Location with ID 1
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Pet
                {
                    Id = 2,
                    Name = "Whiskers",
                    Species = "Cat",
                    Gender = "Female",
                    Breed = "Siamese",
                    Age = 2,
                    Size = "Small",
                    Adoption_Status = "Adopted",
                    Health_Status = "Healthy",
                    Personality_Traits = "Affectionate, Curious",
                    Location_ID = 2, // Reference to an existing Location with ID 2
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Pet
                {
                    Id = 3,
                    Name = "Charlie",
                    Species = "Dog",
                    Gender = "Male",
                    Breed = "Beagle",
                    Age = 4,
                    Size = "Medium",
                    Adoption_Status = "Pending",
                    Health_Status = "Healthy",
                    Personality_Traits = "Energetic, Loyal",
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

