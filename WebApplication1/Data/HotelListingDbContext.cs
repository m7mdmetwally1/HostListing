using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class HotelListingDbContext : DbContext
    {

        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "mohamed",
                    ShortName = "mm"
                },
                new Country
                {
                    Id = 2,
                    Name = "metwally",
                    ShortName = "Me"
                },
                new Country
                {
                    Id = 3,
                    Name = "ahmed",
                    ShortName = "CI"
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
               new Hotel
               {
                   Id = 1,
                   Name = "sandals resort and spa",
                   Adress = "Negril",
                   CountryId =1,
                   Rating= 4.5

               },
               new Hotel
               {
                   Id = 2,
                   Name = "Comfort Suites",
                   Adress = "Grorge Town",
                   CountryId = 1,
                   Rating = 4.5
               },
               new Hotel
               {
                   Id = 3,
                   Name = "Grand Palldium",
                   Adress = "Nassua",
                   CountryId = 1,
                   Rating = 4.5
               }
           );
        }

    }
}


 







