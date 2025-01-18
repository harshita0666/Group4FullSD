using Group4FullSD.Domain;

public class Pet : BaseDomainModel
{
    public string? Name { get; set; }
    public string? Species { get; set; }
    public string? Gender { get; set; }
    public string? Breed { get; set; }
    public int? Age { get; set; }

    public string? Size { get; set; }
    public string? Adoption_Status { get; set; }
    public string? Health_Status { get; set; }
    public string? Personality_Traits { get; set; }

    // Foreign Key for Location
    public int Location_ID { get; set; }
    public Location? Location { get; set; }

    // One-to-One Relationship with Medical Records
    public PetMedicalRecords? MedicalRecord { get; set; }
}
