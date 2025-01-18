    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Group4FullSD.Domain;
    using Group4FullSD.Configurations.Entities;

    namespace Group4FullSD.Data
    {
        public class Group4FullSDContext : IdentityDbContext<Group4FullSDUser>
        {
            public Group4FullSDContext(DbContextOptions<Group4FullSDContext> options) : base(options)
            {
            }

            // DbSets for all entities
            public DbSet<Adopter> Adopter { get; set; } = default!;
            public DbSet<Pet> Pet { get; set; } = default!;
            public DbSet<Location> Location { get; set; } = default!;
            public DbSet<AdoptionApplication> AdoptionApplication { get; set; } = default!;
            public DbSet<PetMedicalRecords> PetMedicalRecord { get; set; } = default!;
            public DbSet<PetTrainingProgram> PetTrainingProgram { get; set; } = default!;
            public DbSet<Staff> Staff { get; set; } = default!;
            public DbSet<Volunteer> Volunteer { get; set; } = default!;
            public DbSet<ShopPetSupplies> ShopPetSupplies { get; set; } = default!;
            public DbSet<Donation> Donation { get; set; } = default!;
            public DbSet<Wishlist> Wishlist { get; set; } = default!;
            public DbSet<Cost> Cost { get; set; } = default!;
            public DbSet<Order> Order { get; set; } = default!;
            public DbSet<AdoptionPreferenceSurvey> AdoptionPreferenceSurvey { get; set; } = default!;

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);

            // Configure the one-to-one relationship between Pet and PetMedicalRecords
            builder.Entity<Pet>()
                .HasOne(p => p.MedicalRecord)       // Pet has one MedicalRecord
                .WithOne(m => m.Pet)               // MedicalRecord has one Pet
                .HasForeignKey<PetMedicalRecords>(m => m.Pet_ID);

                builder.Entity<Pet>()
                    .HasOne(p => p.Location)
                    .WithMany(l => l.Pets)
                    .HasForeignKey(p => p.Location_ID);

                builder.Entity<Staff>()
                    .HasOne(s => s.Location)
                    .WithMany(l => l.StaffMembers)
                    .HasForeignKey(s => s.Location_ID);

                builder.Entity<Volunteer>()
                    .HasOne(v => v.AssignedLocation)
                    .WithMany(l => l.Volunteers)
                    .HasForeignKey(v => v.Assigned_Location_ID);

                builder.Entity<ShopPetSupplies>()
                    .HasOne(s => s.StockedAt)
                    .WithMany(l => l.ShopSupplies)
                    .HasForeignKey(s => s.Location_ID);


            builder.Entity<Cost>()
                   .HasOne(c => c.Staff)
                   .WithMany()
                   .HasForeignKey(c => c.Staff_Reviewed_By)
                   .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete






            builder.Entity<Cost>()
                    .HasOne(c => c.Adopter)
                    .WithMany()
                    .HasForeignKey(c => c.Adopter_ID);

                builder.Entity<Cost>()
                    .HasOne(c => c.Pet)
                    .WithMany()
                    .HasForeignKey(c => c.Pet_ID);

                builder.Entity<Order>()
                    .HasOne(o => o.Adopter)
                    .WithMany()
                    .HasForeignKey(o => o.Adopter_ID);

           
            builder.Entity<Order>()
                    .HasOne(o => o.Staff)
                    .WithMany()
                    .HasForeignKey(o => o.Staff_ID)
                    .OnDelete(DeleteBehavior.Cascade);

                builder.Entity<Wishlist>()
                    .HasOne(w => w.Adopter)
                    .WithMany(a => a.Wishlists)
                    .HasForeignKey(w => w.Adopter_ID);

                builder.Entity<Wishlist>()
                    .HasOne(w => w.Pet)
                    .WithMany()
                    .HasForeignKey(w => w.Pet_ID);

            // Apply seed data configurations
            builder.ApplyConfiguration(new LocationSeed());
            builder.ApplyConfiguration(new StaffSeed());
            builder.ApplyConfiguration(new AdopterSeed());
            builder.ApplyConfiguration(new ShopPetSuppliesSeed());
            builder.ApplyConfiguration(new OrderSeed());
            builder.ApplyConfiguration(new VolunteerSeed());
            builder.ApplyConfiguration(new WishlistSeed());
            builder.ApplyConfiguration(new CostSeed());
            builder.ApplyConfiguration(new AdoptionApplicationSeed());
            builder.ApplyConfiguration(new PetSeed());
            builder.ApplyConfiguration(new PetMedicalRecordsSeed());
            builder.ApplyConfiguration(new PetTrainingProgramSeed());
            builder.ApplyConfiguration(new DonationSeed());
            builder.ApplyConfiguration(new AdoptionPreferenceSurveySeed());
        }
        }
    }



