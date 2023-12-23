using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Data.DbContexts;
public class IcarusDbContext : DbContext
{
    public IcarusDbContext(DbContextOptions<IcarusDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Asset> Assets { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DepartmentResponse> DepartmentResponses { get; set; }
    public DbSet<DepartmentCategory> DepartmentCategories { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    base.OnModelCreating(modelBuilder);

    //    // Category - DepartmentCategory Configuration

    //    //modelBuilder.Entity<Category>()
    //    //    .HasMany(c => c.DepartmentCategories)
    //    //    .WithOne(dc => dc.Category)
    //    //    .HasForeignKey(dc => dc.CategoryId)
    //    //    .OnDelete(DeleteBehavior.Cascade);

    //    //// Department - DepartmentCategory Configuration

    //    //modelBuilder.Entity<Department>()
    //    //    .HasMany(d => d.DepartmentCategories)
    //    //    .WithOne(dc => dc.Department)
    //    //    .HasForeignKey(dc => dc.DepartmentId)
    //    //    .OnDelete(DeleteBehavior.Cascade);

    //       SeedData(modelBuilder);
    //}

    //private static void SeedData(ModelBuilder modelBuilder)
    //{
    //    UserSeedData.SeedDataUsers(modelBuilder);
    //    AssetSeetData.SeedDataAssets(modelBuilder);
    //    DepartamentCategorySeedData.SeedDataDepartamentCategory(modelBuilder);
    //}
}