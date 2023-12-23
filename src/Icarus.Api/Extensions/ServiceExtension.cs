using Icarus.Data.Repositories;
using Icarus.Data.IRepositories;
using Icarus.Data.Repositories.Assets;
using Icarus.Data.IRepositories.Assets;
using Icarus.Service.Interfaces.Assets;
using Icarus.Service.Services.Assets;
<<<<<<< HEAD
using Icarus.Service.Interfaces.DepartmentCategories;
using Icarus.Service.Services.DepartmentCategories;
=======
using Icarus.Service.Interfaces.Users;
using Icarus.Service.Services.Users;
using Icarus.Data.IRepositories.Users;
using Icarus.Data.Repositories.Users;
using Icarus.Service.Interfaces.Categories;
using Icarus.Service.Services.Categories;

>>>>>>> f402d2ca69fb4d62a1a466115dfe5b9cd77079f6

namespace Icarus.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        // Repository
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        // Asset
        services.AddScoped<IAssetService,AssetService>();
        services.AddScoped<IAssetRepository, AssetRepository>();

<<<<<<< HEAD
        // Generic Repository
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        // DepartmentCategory
        services.AddScoped<IDepartmentCategoryService, DepartmentCategoryService>();
        services.AddScoped<IDepartmentCategoryRepository, DepartmentCategoryRepository>();
=======
        // Users
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserRepository, UserRepository>();

        // Category
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ICategoryRepository,CategoryRepository>();

>>>>>>> f402d2ca69fb4d62a1a466115dfe5b9cd77079f6
    }
}