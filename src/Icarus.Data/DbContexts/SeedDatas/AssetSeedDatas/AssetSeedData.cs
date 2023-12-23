//using Icarus.Domain.Entities;
//using Microsoft.EntityFrameworkCore;

//namespace Icarus.Data.DbContexts.SeedDatas.AssetSeedDatas
//{
//    public class AssetSeedData
//    {
//        public static void SeedDataAssets(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Asset>().HasData(
//               new Asset
//               {
//                   Logo = "company1_logo.png",
//                   Rating = 1,
//                   Phone = "+1234567890",
//                   Email = "info@company1.com",
//                   Address = "123 Main St, City1, Country1",
//                   CompanyWebUrl = "http://www.company1.com",
//                   InstagramUrl = "http://instagram.com/company1",
//                   TelegramUrl = "http://t.me/company1",
//                   FacebookUrl = "http://facebook.com/company1",
//                   Latitude = "40.7128",
//                   Longitude = "-74.0060",
//                   CreatedAt = DateTime.UtcNow
//               },

//                new Asset
//                {
//                    Logo = "company5_logo.png",
//                    Rating = 3,
//                    Phone = "+5555555555",
//                    Email = "info@company5.com",
//                    Address = "555 Oak St, City5, Country5",
//                    CompanyWebUrl = "http://www.company5.com",
//                    InstagramUrl = "http://instagram.com/company5",
//                    TelegramUrl = "http://t.me/company5",
//                    FacebookUrl = "http://facebook.com/company5",
//                    Latitude = "35.6895",
//                    Longitude = "139.6917",
//                    CreatedAt = DateTime.UtcNow
//                },

//                new Asset
//                {
//                    Logo = "new_company_logo.png",
//                    Rating = 5,
//                    Phone = "+9999999999",
//                    Email = "info@newcompany.com",
//                    Address = "789 Oak St, New City, New Country",
//                    CompanyWebUrl = "http://www.newcompany.com",
//                    InstagramUrl = "http://instagram.com/newcompany",
//                    TelegramUrl = "http://t.me/newcompany",
//                    FacebookUrl = "http://facebook.com/newcompany",
//                    Latitude =  "45.6789",
//                    Longitude = "-90.1234",
//                    CreatedAt = DateTime.UtcNow
//                }
//            );
//        }
//    }
//}
