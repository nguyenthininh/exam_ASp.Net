using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


namespace HRM.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
               .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        Name = "Ninh",
                        Gender = "Female",
                        Birthday= new DateTime(2000,10,27),
                        Telephone = 0987654321,
                        Email = "ninhnt2000@gmail.com",
                        Address = "Bac Ninh"
                    },
                    new Employee
                    {
                        Name = "Kayak",
                        Gender = "Female",
                        Birthday = new DateTime(2000, 11, 20),
                        Telephone = 0987654321,
                        Email = "nguyenvana@gmail.com",
                        Address = "Ha Noi"
                    },
                    new Employee
                    {
                        Name = "Lifejacket",
                        Gender = "Male",
                        Birthday = new DateTime(2000, 10, 27),
                        Telephone = 0987654321,
                        Email = "nguyenvanb@gmail.com",
                        Address = "Hai Phong"
                    },
                    new Employee
                    {
                        Name = "Ball",
                        Gender = "Male",
                        Birthday = new DateTime(1999, 9, 20),
                        Telephone = 0987654321,
                        Email = "nguyenvanc@gmail.com",
                        Address = "Bac Ninh"
                    },
                    new Employee
                    {
                        Name = "Jenny",
                        Gender = "Female",
                        Birthday = new DateTime(1998, 11, 2),
                        Telephone = 0987654321,
                        Email = "nguyenvand@gmail.com",
                        Address = "Ha Noi"
                    }

                    );
                context.SaveChanges();
            }
        }

    }
}
