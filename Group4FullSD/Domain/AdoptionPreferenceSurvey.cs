namespace Group4FullSD.Domain
{
    public class AdoptionPreferenceSurvey : BaseDomainModel
    {
        // Attributes
        public int Adopter_ID { get; set; } // Foreign key to Adopter
        public int Pet_ID { get; set; }     // Foreign key to Pet

        public string? Question { get; set; } //Survey Question
        public string? Answer { get; set; } // Answers to the survey
        public DateTime Submission_Date { get; set; } // Date of survey submission

        // Navigation Properties        
        public Adopter? Adopter { get; set; } // Reference to the Adopter entity
        public Pet? Pet { get; set; }         // Reference to the Pet entity
    }
}

