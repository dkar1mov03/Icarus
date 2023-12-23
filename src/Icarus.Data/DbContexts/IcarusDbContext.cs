using Icarus.Data.DbContexts.SeedDatas.AssetSeedDatas;
using Icarus.Data.DbContexts.SeedDatas.DepartmentCategorySeedDatas;
using Icarus.Data.DbContexts.SeedDatas.UserSeedDatas;
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
    public DbSet<Category> Categories { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DepartmentCategory> DepartmentCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        SeedData(modelBuilder);
    }
    private static void SeedData(ModelBuilder modelBuilder)
    {
        UserSeedData.SeedDataUsers(modelBuilder);
        AssetSeedData.SeedDataAssets(modelBuilder);
        DepartamentCategorySeedData.SeedDataDepartamentCategory(modelBuilder);
    }
}
