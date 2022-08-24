using Microsoft.EntityFrameworkCore;

namespace LaunchApi.Models
{
    public class LaunchApiContext : DbContext
    {
        public LaunchApiContext(DbContextOptions<LaunchApiContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
        builder.Entity<Launch>()
            .HasData(
                new Launch { LaunchId = 1, Mission="Artemis", Location= "Kennedy Space Center", DaysToLaunch=5 },
                new Launch { LaunchId = 2, Mission="Starlink-58 (3-4)", Location= "Vandenberg SFB", DaysToLaunch=6 },
                new Launch { LaunchId = 3, Mission="Starlink-59(4-20)", Location= "Cape Canaveral", DaysToLaunch=11 },
                new Launch { LaunchId = 4, Mission="Eutelsat Konnect VHTS", Location= "Guiana Space Centre", DaysToLaunch=13 },
                new Launch { LaunchId = 5, Mission="RS1 Flight 1", Location= "Pacific Spaceport Complex - A", DaysToLaunch=13 },
                new Launch { LaunchId = 6, Mission="Starlink (4-2)", Location= "Kennedy Space Center", DaysToLaunch=14 },
                new Launch { LaunchId = 7, Mission="To the Black", Location= "Vandenberg SFB", DaysToLaunch=18 },
                new Launch { LaunchId = 8, Mission="Soyuz MS-22", Location= "Baikonur Cosmodrome", DaysToLaunch=29 },
                new Launch { LaunchId = 9, Mission="NROL-91", Location= "Vandenberg SFB", DaysToLaunch=32 },
                new Launch { LaunchId = 10, Mission="The Owl Spreads Its Wings", Location= "Rocket Lab Launch Complex", DaysToLaunch=30 }
            );
        }

        public DbSet<Launch> Launches { get; set; }
    }
}