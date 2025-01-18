using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class PetTrainingProgramSeed : IEntityTypeConfiguration<PetTrainingProgram>
    {
        public void Configure(EntityTypeBuilder<PetTrainingProgram> builder)
        {
            builder.HasData(
                new PetTrainingProgram
                {
                    Id = 1,
                    Pet_ID = 1, // Reference to an existing Pet with ID 1
                    Program_Name = "Basic Obedience Training",
                    Start_Date = new DateTime(2023, 6, 1),
                    End_Date = new DateTime(2023, 6, 30),
                    Trainer_Name = "John Doe",
                    Status = "Completed",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new PetTrainingProgram
                {
                    Id = 2,
                    Pet_ID = 2, // Reference to an existing Pet with ID 2
                    Program_Name = "Agility Training",
                    Start_Date = new DateTime(2023, 7, 15),
                    End_Date = new DateTime(2023, 8, 15),
                    Trainer_Name = "Jane Smith",
                    Status = "Ongoing",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new PetTrainingProgram
                {
                    Id = 3,
                    Pet_ID = 3, // Reference to an existing Pet with ID 3
                    Program_Name = "Socialization Program",
                    Start_Date = new DateTime(2023, 5, 20),
                    End_Date = new DateTime(2023, 6, 20),
                    Trainer_Name = "Alice Johnson",
                    Status = "Completed",
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

