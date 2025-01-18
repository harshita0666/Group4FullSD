namespace Group4FullSD.Domain
{
    public class Location : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Contact_Number { get; set; }

        // Relationships
        public ICollection<Pet> Pets { get; set; } = new List<Pet>();
        public ICollection<Staff> StaffMembers { get; set; } = new List<Staff>();
        public ICollection<Volunteer> Volunteers { get; set; } = new List<Volunteer>();
        public ICollection<ShopPetSupplies> ShopSupplies { get; set; } = new List<ShopPetSupplies>(); // Corrected type
    }
}


