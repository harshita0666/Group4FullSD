using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Group4FullSD.Domain;

namespace Group4FullSD.Configurations.Entities
{
    public class VolunteerSeed : IEntityTypeConfiguration<Volunteer>
    {
        public void Configure(EntityTypeBuilder<Volunteer> builder)
        {
            builder.HasData(
                new Volunteer
                {
                    Id = 1,
                    Name = "Emily Brown",
                    Email = "emily.brown@example.com",
                    Phone_Number = "123-456-7890",
                    Availability = "Weekends",
                    Role = "Helper",
                    Registration_Date = new DateTime(2023, 1, 10),
                    Assigned_Location_ID = 1, // Reference to an existing Location with ID 1
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Volunteer
                {
                    Id = 2,
                    Name = "David Wilson",
                    Email = "david.wilson@example.com",
                    Phone_Number = "987-654-3210",
                    Availability = "Full-time",
                    Role = "Coordinator",
                    Registration_Date = new DateTime(2023, 5, 15),
                    Assigned_Location_ID = 2, // Reference to an existing Location with ID 2
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Volunteer
                {
                    Id = 3,
                    Name = "Sophia Martinez",
                    Email = "sophia.martinez@example.com",
                    Phone_Number = "555-555-5555",
                    Availability = "Weekdays",
                    Role = "Assistant",
                    Registration_Date = new DateTime(2023, 3, 20),
                    Assigned_Location_ID = 3, // Reference to an existing Location with ID 3
                    DateCreated = DateTime.UtcNow,
                    DateUpdated = DateTime.UtcNow,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}

