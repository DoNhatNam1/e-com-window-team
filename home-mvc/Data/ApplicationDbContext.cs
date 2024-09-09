using EComWindowTeam.ClientMvc.Models;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products { get; set; } // Tên DbSet giữ nguyên như 'Products'

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .ToTable("Product") // Đặt tên bảng là 'Product'
            .Property(p => p.Id)
            .HasColumnName("id"); // Đặt tên cột cho thuộc tính Id
        modelBuilder.Entity<Product>()
            .Property(p => p.CategoryId)
            .HasColumnName("categoryid"); // Đặt tên cột cho thuộc tính CategoryId
        modelBuilder.Entity<Product>()
            .Property(p => p.Name)
            .HasColumnName("name"); // Đặt tên cột cho thuộc tính Name
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnName("price"); // Đặt tên cột cho thuộc tính Price
    }
}
