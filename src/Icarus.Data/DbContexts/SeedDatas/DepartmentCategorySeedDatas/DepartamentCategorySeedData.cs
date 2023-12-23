//using Icarus.Domain.Entities;
//using Microsoft.EntityFrameworkCore;

//namespace Icarus.Data.DbContexts.SeedDatas.DepartmentCategorySeedDatas
//{
//    public class DepartamentCategorySeedData
//    {
//        public static void SeedDataDepartamentCategory(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<DepartmentCategory>().HasData(

//             new DepartmentCategory { DepartmentId = 1, CategoryId = 1, Description = "Sample Description 1", CreatedAt = DateTime.UtcNow },
//             new DepartmentCategory { DepartmentId = 2, CategoryId = 2, Description = "Sample Description 2", CreatedAt = DateTime.UtcNow },
//             new DepartmentCategory { DepartmentId = 3, CategoryId = 1, Description = "Sample Description 3", CreatedAt = DateTime.UtcNow },
//             new DepartmentCategory { DepartmentId = 4, CategoryId = 3, Description = "Sample Description 4", CreatedAt = DateTime.UtcNow },
//             new DepartmentCategory { DepartmentId = 5, CategoryId = 2, Description = "Sample Description 5", CreatedAt = DateTime.UtcNow }
//           );
//        }
//    }
//}
