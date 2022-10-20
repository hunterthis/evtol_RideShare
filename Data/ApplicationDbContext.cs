using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using evtol_RideShare.Models;

namespace evtol_RideShare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Passenger> Passenger { get; set; }
        public DbSet<Pilot> Pilot { get; set; }
    }
}