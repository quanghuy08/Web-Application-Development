using Project5.Models;
using System;
using System.Linq;

namespace Project5.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ShopContext context)
        {
            context.Database.EnsureCreated();

           
            if (context.Categories.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
            new Category{Name="Quần Đùi",EnrollmentDate=DateTime.Parse("2021-11-01")},
            new Category{Name="Áo",EnrollmentDate=DateTime.Parse("2021-11-02")},
            new Category{Name="Quần Dài",EnrollmentDate=DateTime.Parse("2021-11-03")},
            new Category{Name="Áo Khoác",EnrollmentDate=DateTime.Parse("2021-11-04")},
            };

            foreach (Category s in categories)
            {
                context.Categories.Add(s);
            }
            context.SaveChanges();

            var products = new Product[]
             {
            new Product{CategoryID=1,Name="Quần Đùi 1",Price=100,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-01")},
            new Product{CategoryID=1,Name="Quần Đùi 2",Price=200,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-01")},
            new Product{CategoryID=1,Name="Quần Đùi 3",Price=300,Unit=3,EnrollmentDate=DateTime.Parse("2021-11-01")},
            new Product{CategoryID=2,Name="Áo 1",Price=200,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-01")},
            new Product{CategoryID=2,Name="Áo 2",Price=100,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-01")},
            new Product{CategoryID=3,Name="Quần Dài 1",Price=1200,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-01")},
            new Product{CategoryID=3,Name="Quần Dài 2",Price=3100,Unit=3,EnrollmentDate=DateTime.Parse("2021-11-01")},
            new Product{CategoryID=4,Name="Áo Khoác 1",Price=1020,Unit=22,EnrollmentDate=DateTime.Parse("2021-11-01")},
            new Product{CategoryID=4,Name="Áo Khoác 2",Price=1200,Unit=14,EnrollmentDate=DateTime.Parse("2021-11-01")},
             };

            foreach (Product s in products)
            {
                context.Products.Add(s);
            }
            context.SaveChanges();
        }
    }
}