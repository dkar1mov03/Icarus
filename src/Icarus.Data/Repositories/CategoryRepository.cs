using Icarus.Data.DbContexts;
using Icarus.Data.IRepositories;
using Icarus.Domain.Entities;

namespace Icarus.Data.Repositories;

public class CategoryRepository : Repository<Category, short>, ICategoryRepository
{
    public CategoryRepository(IcarusDbContext DbContext) : base(DbContext)
    {
    }
}
