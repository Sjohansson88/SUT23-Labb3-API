using Microsoft.EntityFrameworkCore;
using SUT23_Labb3_API.Models;

namespace SUT23_Labb3_API.Data
{
    public class ILabbDbContext : DbContext    
    {
        public ILabbDbContext(DbContextOptions<ILabbDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Interest> Interests { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<PersonInterest> PersonInterests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 1, FirstName = "Håkan", LastName = "Svensson", PhoneNumber = "012345678" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 2, FirstName = "Mats", LastName = "Larsson", PhoneNumber = "45678123" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 3, FirstName = "Lisa", LastName = "Nilsson", PhoneNumber = "00011678" });
            modelBuilder.Entity<Person>().HasData(new Person { PersonId = 4, FirstName = "Siv", LastName = "Persson", PhoneNumber = "07868745" });



            modelBuilder.Entity<Interest>().HasData(new Interest { InterestId = 101, InterestName = "Golf", InterestDesc = "Gå runt och slå på en vit boll"});
            modelBuilder.Entity<Interest>().HasData(new Interest { InterestId = 102, InterestName = "Fotboll", InterestDesc = "Springa i en klunga och sparka på en boll" });
            modelBuilder.Entity<Interest>().HasData(new Interest { InterestId = 103, InterestName = "Kolla TV", InterestDesc = "Sitta och ta det lugnt" });
            modelBuilder.Entity<Interest>().HasData(new Interest { InterestId = 104, InterestName = "Studera", InterestDesc = "Sitta och lära sig saker" });



            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 201, Url = "www.golf.se", PersonInterestId = 1 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 202, Url = "www.football.com", PersonInterestId = 1 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 203, Url = "www.netflix.com", PersonInterestId = 2 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 204, Url = "www.campus.varberg.se", PersonInterestId = 2 });
            modelBuilder.Entity<Link>().HasData(new Link { LinkId = 205, Url = "www.aftonbladet.se", PersonInterestId = 2 });

            modelBuilder.Entity<PersonInterest>().HasData(new PersonInterest { PersonInterestId = 1, PersonId = 1, InterestId =101 });
            modelBuilder.Entity<PersonInterest>().HasData(new PersonInterest { PersonInterestId = 2, PersonId = 2, InterestId = 102 });
        }
    }
}
