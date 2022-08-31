using CompanyMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CompanyMvc.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var dbContext = new CompanyMvcContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CompanyMvcContext>>()))
            {
                // Look for any movies.
                if (dbContext.Employee.Any())
                {
                    return; // DB has been seeded
                }

                dbContext.Employee.AddRange(
                    new Employee
                    {
                        EmployeeName = "Employee001",
                        Gender = "Male",
                        DateOfBirth = DateTime.Parse("01-01-1990"),
                        Nationality = "American",
                        City = "Los Angeles",
                        CurrentAdress = "Current Address",
                        PermanentAdress = "Permanent Address",
                        PINCode = "560078",
                        Position = "RH",
                        SoldeDeCongé = 18
                    },
                    new Employee
                    {
                        EmployeeName = "Employee002",
                        Gender = "Female",
                        DateOfBirth = DateTime.Parse("21-07-1994"),
                        Nationality = "British",
                        City = "London",
                        CurrentAdress = "Current Address",
                        PermanentAdress = "Permanent Address",
                        PINCode = "620068",
                        Position = "CEO",
                        SoldeDeCongé = 20
                    },
                    new Employee
                    {
                        EmployeeName = "Employee003",
                        Gender = "Female",
                        DateOfBirth = DateTime.Parse("30-12-1995"),
                        Nationality = "Moroccan",
                        City = "Casablanca",
                        CurrentAdress = "Current Address",
                        PermanentAdress = "Permanent Address",
                        PINCode = "619068",
                        Position = "Marketing Manager",
                        SoldeDeCongé = 24
                    });

                dbContext.SaveChanges();
            }
        }
    }
}
