using Icarus.Data.Repositories;
using Icarus.Data.IRepositories;
using Icarus.Data.Repositories.Assets;
using Icarus.Data.IRepositories.Assets;
using Icarus.Service.Interfaces.Assets;
using Icarus.Service.Services.Assets;
using Icarus.Service.Interfaces.Categories;
using Icarus.Service.Services.Categories;

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

        // Category
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ICategoryRepository,CategoryRepository>();
    }
}