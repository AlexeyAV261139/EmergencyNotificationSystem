using ENS.DBAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace ENS.DBAccess
{
    public class ENSContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; } = null!;

        public DbSet<ContactEntity> Contacts { get; set; } = null!;

        public DbSet<MessengerEntity> Messengers { get; set; } = null!;

        public ENSContext()
        {
            //    Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=EmergencyNotificationSystem;Trusted_Connection=True;Encrypt=false");
        }
    }
}
