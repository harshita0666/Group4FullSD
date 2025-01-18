namespace Group4FullSD.Domain
{
    public class PetTrainingProgram : BaseDomainModel
    {
        public int Pet_ID { get; set; }
        public Pet? Pet { get; set; }
        public string? Program_Name { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public string? Trainer_Name { get; set; }
        public string? Status { get; set; }
    }
}
