namespace Group4FullSD.Domain
{
    public class Adopter : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public string? Address { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string? Adoption_History { get; set; }
        public DateTime Registration_Date { get; set; }

        // Relationships
        public ICollection<AdoptionApplication>? Applications { get; set; }
        public ICollection<Wishlist>? Wishlists { get; set; }
        public ICollection<Donation>? Donations { get; set; }
    }
}




