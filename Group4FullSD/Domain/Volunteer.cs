namespace Group4FullSD.Domain
{
    public class Volunteer : BaseDomainModel
    {
        // Attributes
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Phone_Number { get; set; }
        public string? Availability { get; set; } // e.g., "Weekends", "Full-time", etc.
        public string? Role { get; set; } // e.g., "Helper", "Coordinator", etc.
        public DateTime Registration_Date { get; set; }

        // Foreign Key
        public int Assigned_Location_ID { get; set; }
        public Location? AssignedLocation { get; set; } // Navigation property
    }
}

