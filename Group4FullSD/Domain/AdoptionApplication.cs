namespace Group4FullSD.Domain
{
    public class AdoptionApplication : BaseDomainModel
    {
        public int Adopter_ID { get; set; }
        public Adopter? Adopter { get; set; }
        public int Pet_ID { get; set; }
        public Pet? Pet { get; set; }
        public string? Application_Status { get; set; }
        public DateTime Submission_Date { get; set; }
        public DateTime Approval_Date { get; set; }
        public int Staff_Reviewed_By { get; set; }
        public Staff? ReviewedBy { get; set; }
    }
}
