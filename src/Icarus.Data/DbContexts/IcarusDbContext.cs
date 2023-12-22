using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Data.DbContexts;
public class IcarusDbContext:DbContext
{
    public IcarusDbContext(DbContextOptions<IcarusDbContext> options):base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<DepartmentCategory> DepartmentCategories { get; set; }
}
