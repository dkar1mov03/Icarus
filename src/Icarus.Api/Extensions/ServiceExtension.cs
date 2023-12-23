using Icarus.Data.Repositories;
using Icarus.Data.IRepositories;
using Icarus.Data.Repositories.Assets;
using Icarus.Data.IRepositories.Assets;
using Icarus.Service.Interfaces.Assets;
using Icarus.Service.Services.Assets;
using Icarus.Service.Interfaces.DepartmentCategories;
using Icarus.Service.Services.DepartmentCategories;

namespace Icarus.Api.Extensions;

public static class ServiceExtension
{
    public static void AddCustomService(this IServiceCollection services)
    {
        // Repository
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        // Assets
        services.AddScoped<IAssetService,AssetService>();
        services.AddScoped<IAssetRepository, AssetRepository>();

        // Generic Repository
        services.AddScoped(typeof(IRepository<,>), typeof(Repository<,>));

        // DepartmentCategory
        services.AddScoped<IDepartmentCategoryService, DepartmentCategoryService>();
        services.AddScoped<IDepartmentCategoryRepository, DepartmentCategoryRepository>();
    }
}