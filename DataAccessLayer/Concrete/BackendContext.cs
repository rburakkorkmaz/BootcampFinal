using Bogus;
using EntityLayer;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class BackendContext : DbContext
    {
        private const int numberOfUserMockData = 30;
        private const int numberOfMissingPetMockData = 15;
        private const int numberOfFoundPetMockData = 15;
        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }
        public DbSet<MissingPet> MissingPets { get; set; }
        public DbSet<FoundPet> FoundPets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = >SERVER_NAME<; Database = >DATABASE_NAME<; Trusted_Connection = True");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var userIds = 1;
            var petIds = 1;
            Random random = new Random();
            modelBuilder.Ignore<BaseEntity>();

            var user = new Faker<User>()
                .RuleFor(u => u.Id, u => userIds++)
                .RuleFor(u => u.Name, u => u.Name.FirstName())
                .RuleFor(u => u.Surname, u => u.Name.LastName())
                .RuleFor(u => u.Username, u => u.Internet.UserName())
                .RuleFor(u => u.Password, u => u.Internet.Password(15))
                .RuleFor(u => u.PhoneNumber, u => u.Phone.PhoneNumber())
                .RuleFor(u => u.Address, u => u.Address.FullAddress());

            

            var missingPet = new Faker<MissingPet>()
                .RuleFor(m => m.Id, m => petIds++)
                .RuleFor(u => u.Name, u => u.Name.FirstName())
                .RuleFor(u => u.Species, u => PetMockData.speciesAndBreed.Keys.ElementAt((petIds - 1) % 3))
                .RuleFor(u => u.Breed, u => u.PickRandom(PetMockData.speciesAndBreed[PetMockData.speciesAndBreed.Keys.ElementAt((petIds-1)%3)]))
                .RuleFor(u => u.Age, u => random.Next(0, 30))
                .RuleFor(u => u.Health, u => u.PickRandom(PetMockData.animalHealths))
                .RuleFor(u => u.MissingDate, u => u.Date.Past())
                .RuleFor(u => u.LastSeenAddress, u => u.Address.FullAddress())
                .RuleFor(u => u.UserId, u => random.Next(1, numberOfUserMockData));

            

            var foundPet = new Faker<FoundPet>()
                .RuleFor(f => f.Id, f => petIds++)
                .RuleFor(u => u.Name, u => u.Name.FirstName())
                .RuleFor(u => u.Species, u => PetMockData.speciesAndBreed.Keys.ElementAt((petIds - 1) % 3))
                .RuleFor(u => u.Breed, u => u.PickRandom(PetMockData.speciesAndBreed[PetMockData.speciesAndBreed.Keys.ElementAt((petIds - 1) % 3)]))
                .RuleFor(u => u.Age, u => random.Next(0, 30))
                .RuleFor(u => u.Health, u => u.PickRandom(PetMockData.animalHealths))
                .RuleFor(u => u.FindingDate, u => u.Date.Past())
                .RuleFor(u => u.FoundAddress, u => u.Address.FullAddress())
                .RuleFor(u => u.UserId, u => random.Next(1, numberOfUserMockData));

            modelBuilder.Entity<User>().HasData(user.Generate(numberOfUserMockData));
            modelBuilder.Entity<MissingPet>().HasData(missingPet.Generate(numberOfMissingPetMockData));
            modelBuilder.Entity<FoundPet>().HasData(foundPet.Generate(numberOfFoundPetMockData));
        }
    }
}
