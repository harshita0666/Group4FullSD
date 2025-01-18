namespace Group4FullSD.Domain
{
    public class ShopPetSupplies : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Category { get; set; }
        public double Pricing { get; set; }
        public int Quantity { get; set; }

        // Relationships
        public int Location_ID { get; set; }
        public Location? StockedAt { get; set; }
    }
}
