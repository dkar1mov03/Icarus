﻿using Icarus.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Icarus.Data.DbContexts.SeedDatas.UserSeedDatas
{
    public class UserSeedData
    {
        public static void SeedDataUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
            new User
            {
                FirstName = "John",
                LastName = "Doe",
                Id = 1,
                Password = "securepassword123",
                Email = "john.doe@example.com",
                Image = "https://example.com/johndoe.jpg",
                CreatedAt = DateTime.UtcNow
            },

            new User
            {

                FirstName = "Alice",
                LastName = "Smith",
                Id = 2,
                Password = "strongpass456",
                Email = "alice.smith@example.com",
                Image = "https://example.com/alicesmith.jpg",
                CreatedAt = DateTime.UtcNow
            },

            new User
            {
                FirstName = "Bob",
                LastName = "Johnson",
                Id = 3,
                Password = "pass1234",
                Email = "bob.johnson@example.com",
                Image = "https://example.com/bobjohnson.jpg",
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                FirstName = "Sara",
                LastName = "Williams",
                Id = 4,
                Password = "saraspass789",
                Email = "sara.williams@example.com",
                Image = "https://example.com/sarawilliams.jpg",
                CreatedAt = DateTime.UtcNow
            },
            new User
            {
                FirstName = "Mike",
                LastName = "Brown",
                Id = 5,
                Password = "mikepass567",
                Email = "mike.brown@example.com",
                Image = "https://example.com/mikebrown.jpg",
                CreatedAt = DateTime.UtcNow
            }
            );
        }
    }
}
