using Group4FullSD.Domain;

public class PetMedicalRecords : BaseDomainModel
{
    public int Pet_ID { get; set; } // Foreign key to Pet
    public Pet? Pet { get; set; }   // Navigation property

    public string? Vaccination_Status { get; set; }
    public string? Medical_Conditions { get; set; }
    public DateTime Last_Checkup_Date { get; set; }
    public string? Medical_History { get; set; }
}

