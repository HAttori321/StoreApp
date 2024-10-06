using Microsoft.EntityFrameworkCore;
using StoreApp.Models;
public static class ModelSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>().HasData(
            new Country { Id = 1, Name = "USA" },
            new Country { Id = 2, Name = "Canada" }
        );
        modelBuilder.Entity<City>().HasData(
            new City { Id = 1, Name = "New York", CountryId = 1 },
            new City { Id = 2, Name = "Toronto", CountryId = 2 }
        );
        modelBuilder.Entity<Position>().HasData(
            new Position { Id = 1, Name = "Manager" },
            new Position { Id = 2, Name = "Salesperson" }
        );
        modelBuilder.Entity<Category>().HasData(
            new Category { Id = 1, Name = "Electronics" },
            new Category { Id = 2, Name = "Clothing" }
        );
    }
}