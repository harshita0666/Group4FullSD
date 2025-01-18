namespace Group4FullSD.Domain
{
    public class Order : BaseDomainModel
    {
        public int Adopter_ID { get; set; } // Foreign key
        public Adopter? Adopter { get; set; } // Navigation property

        public int Supply_ID { get; set; } // Foreign key
        // public Staff? Staff { get; set; } // Navigation property
        public ShopPetSupplies? ShopPetSupplies { get; set; } // Navigation property

        public DateTime? Order_Date { get; set; } // Date of the order
        public double Total_Price { get; set; } // Total price of the order
        public int Staff_ID { get; set; } // Is this a FK or what???
        public Staff? Staff { get; set; } // Navigation property .. If above is FK, then u need this nav
    }
}
