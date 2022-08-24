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
                new Launch { LaunchId = 10, Mission="The Owl Spreads Its Wings", Location= "Rocket Lab Launch Complex", DaysToLaunch=32 },
                new Launch { LaunchId = 11, Mission="SES-20 & SES-21", Location= "Cape Canaveral", DaysToLaunch=32 },
                new Launch { LaunchId = 12, Mission="Oceansat-3 (EOS-6)", Location= "FLP, Satish Dhawan Space Centre, India", DaysToLaunch=32 },
                new Launch { LaunchId = 13, Mission="Good Luck, Have Fun", Location= "Cape Canaveral SFS", DaysToLaunch=32 },
                new Launch { LaunchId = 14, Mission="CRS2 NG-18 (Cygnus)", Location= "Rocket Lab Launch Complex", DaysToLaunch=32 },
                new Launch { LaunchId = 15, Mission="O3b mPower-1", Location= "Cape Canaveral KSC", DaysToLaunch=52 },
                new Launch { LaunchId = 16, Mission="O3b mPower-2", Location= "Rocket Lab Launch Complex", DaysToLaunch=52},
                new Launch { LaunchId = 17, Mission="Crew-5", Location= "Kennedy Space Center", DaysToLaunch=52},
                new Launch { LaunchId = 18, Mission="SES-18 & SES-19", Location= "Cape Canaveral", DaysToLaunch=52},
                new Launch { LaunchId = 19, Mission="JPSS-2", Location= "Vandenberg SFB", DaysToLaunch=72},
                new Launch { LaunchId = 20, Mission="Transporter-6", Location= "Cape Canaveral", DaysToLaunch=82},
                new Launch { LaunchId = 21, Mission="SWOT", Location= "Vandenberg SFB", DaysToLaunch=82},
                new Launch { LaunchId = 22, Mission="USSF-67", Location= "Kennedy Space Center", DaysToLaunch=82},
                new Launch { LaunchId = 23, Mission="Polaris Dawn", Location= "Kennedy Space Center", DaysToLaunch=100},
                new Launch { LaunchId = 24, Mission="HawkEye 360 Flight 1/3", Location= "Rocket Lab LC-2", DaysToLaunch=100},
                new Launch { LaunchId = 25, Mission="PACE", Location= "Cape Canveral", DaysToLaunch=100}
            );
        }

        public DbSet<Launch> Launches { get; set; }
    }
}