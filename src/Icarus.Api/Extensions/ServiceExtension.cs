using Icarus.Data.Repositories;
using Icarus.Data.IRepositories;
using Icarus.Service.Services.Users;
using Icarus.Service.Services.Assets;
using Icarus.Data.Repositories.Users;
using Icarus.Data.Repositories.Assets;
using Icarus.Service.Interfaces.Users;
using Icarus.Data.IRepositories.Users;
using Icarus.Service.Interfaces.Assets;
using Icarus.Data.IRepositories.Assets;
using Icarus.Service.Services.Categories;
using Icarus.Service.Interfaces.Categories;
using Icarus.Service.Services.DepartmentCategories;
using Icarus.Service.Interfaces.DepartmentCategories;
using Icarus.Service.Interfaces.Departments;
using Icarus.Service.Services.Departments;
using Icarus.Domain.Entities;
using Icarus.Data.Repositories.Departments;
using Icarus.Service.Interfaces.DepartmentResponses;
using Icarus.Service.Services.DepartmentResponses;
using Icarus.Service.Services.Requests;
using Icarus.Service.Interfaces.Requests;



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


        // Department
        services.AddScoped<IDepartmentService, DepartmentService>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();

        // DepartmentCategory
        services.AddScoped<IDepartmentCategoryService, DepartmentCategoryService>();
        services.AddScoped<IDepartmentCategoryRepository, DepartmentCategoryRepository>();

        // DepartmentResponse
        services.AddScoped<IDepartmentResponseService, DepartmentResponseService>();
        services.AddScoped<IDepartmentResponseReposiroty, DepartmentResponseRepository>();

        // Users
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserRepository, UserRepository>();

        // Category
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ICategoryRepository,CategoryRepository>();

        // Request
        services.AddScoped<IRequestService, RequestService>(); 
        services.AddScoped<IRequestRepository, RequestRepository>(); 
    }
}