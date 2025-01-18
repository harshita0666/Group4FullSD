namespace Group4FullSD.Domain
{
    public class Wishlist : BaseDomainModel
    {
        public int Adopter_ID { get; set; }
        public Adopter? Adopter { get; set; }
        public int Pet_ID { get; set; }
        public Pet? Pet { get; set; }
        public DateTime Added_Date { get; set; }
    }
}
