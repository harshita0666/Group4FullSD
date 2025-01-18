namespace Group4FullSD.Domain
{
    public class Donation : BaseDomainModel
    {
        public int Donor_ID { get; set; }
        public Adopter? Donor { get; set; }

        public double Donation_Amount { get; set; }
        public DateTime Donation_Date { get; set; }
        public int Location_ID { get; set; }
        public Location? Location { get; set; }
    }
}

