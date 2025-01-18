namespace Group4FullSD.Domain
{
    public class Cost : BaseDomainModel
    {
        // Foreign keys
        public int Adopter_ID { get; set; } // Reference to the Adopter
        public Adopter? Adopter { get; set; }

        public int Pet_ID { get; set; } // Reference to the Pet
        public Pet? Pet { get; set; }

        public int Staff_Reviewed_By { get; set; } // Reference to the Staff who reviewed
        public Staff? Staff { get; set; }

        // Attributes
        public double Adoption_Cost { get; set; }
        public string? Adoption_Status { get; set; } // e.g., "Paid", "Pending", "Approved"
        public DateTime Submission_Date { get; set; }
        public DateTime? Approval_Date { get; set; }
    }
}

