using Microsoft.EntityFrameworkCore;
using EComWindowTeam.HomeMvc.Models;

namespace EComWindowTeam.HomeMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<TbUser> TbUsers { get; set; }
        public DbSet<TbOrder> TbOrders { get; set; }
        public DbSet<TbConfiguration> TbConfigurations { get; set; }
        public DbSet<TbShippingAddress> TbShippingAddresses { get; set; }
        public DbSet<TbTemporaryAddress> TbTemporaryAddresses { get; set; }
        // public DbSet<GetDbConnections> GetDbConnection { get; set; }

        
         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbUser>().ToTable("TbUser"); 

            base.OnModelCreating(modelBuilder);
            // Configure relationships
            modelBuilder.Entity<TbOrder>()
                .HasOne(o => o.Configuration)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.ConfigurationId);

            modelBuilder.Entity<TbOrder>()
                .HasOne(o => o.User)
                .WithMany(u => u.orders)
                .HasForeignKey(o => o.UserId);

            modelBuilder.Entity<TbOrder>()
                .HasOne(o => o.ShippingAddress)
                .WithMany(a => a.Orders)
                .HasForeignKey(o => o.ShippingAddressId)
                .IsRequired(false);

            modelBuilder.Entity<TbTemporaryAddress>()
                .HasOne(a => a.Order)
                .WithOne(o => o.TemporaryAddress)
                .HasForeignKey<TbTemporaryAddress>(a => a.OrderId);

            base.OnModelCreating(modelBuilder);
        }
    
    }
}