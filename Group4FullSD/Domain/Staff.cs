namespace Group4FullSD.Domain
{
    public class Staff : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public string? Role { get; set; }
        public DateTime Join_Date { get; set; }

        // Relationships
        public int Location_ID { get; set; }
        public Location? Location { get; set; }
        public ICollection<AdoptionApplication>? ApplicationsReviewed { get; set; }
    }
}
