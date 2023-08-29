using DrinkShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using DrinkShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DrinkShop.Data.Configurations;

namespace DrinkShop.Data.Extensions
{
    public static class ModelBuiderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page of DrinkShop " },
               new AppConfig() { Key = "HomeKeyWord", Value = "This is keyword of DrinkShop " },
               new AppConfig() { Key = "HomeDescription", Value = "This is description of DrinkShop " }
               );


            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });

            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = 1, IsShowOnHome = true, ParentId = null, SortOrder = 1, Status = Status.Active, },
                 new Category()
                 {
                     Id = 2,
                     IsShowOnHome = true,
                     ParentId = null,
                     SortOrder = 2,
                     Status = Status.Active
                 });

            modelBuilder.Entity<CategoryTranslation>().HasData(
                  new CategoryTranslation() { Id = 1, CategoryId = 1, Name = "Coca Cola", LanguageId = "vi-VN", SeoAlias = "coca-cola", SeoDescription = "Sản phẩm nước uống có gas", SeoTitle = "Sản phẩm từ thương hiệu Coca Cola" },
                  new CategoryTranslation() { Id = 2, CategoryId = 1, Name = "7 Up", LanguageId = "en-US", SeoAlias = "seven-up", SeoDescription = "Carbonated soft drinks", SeoTitle = "The products from Dr Pepper Snapple Group of America and PepsiCo brand" },
                  new CategoryTranslation() { Id = 3, CategoryId = 2, Name = "Pepsi", LanguageId = "vi-VN", SeoAlias = "Pepsi", SeoDescription = "Sản phẩm nước uống có gas", SeoTitle = "Sản phẩm đến từ thương hiệu PepsiCo, Inc" },
                  new CategoryTranslation() { Id = 4, CategoryId = 2, Name = "Sprite", LanguageId = "en-US", SeoAlias = "Sprite", SeoDescription = "Carbonated soft drinks", SeoTitle = "The products from the brand Coca Cola" }
                    );

            modelBuilder.Entity<Product>().HasData(
           new Product()
           {
               Id = 1,
               DateCreate = DateTime.Now,
               OriginalPrice = 100000,
               Price = 200000,
               Stock = 0,
               ViewCount = 0,
           });
            modelBuilder.Entity<ProductTranslation>().HasData(
                 new ProductTranslation()
                 {
                     Id = 1,
                     ProductId = 1,
                     Name = "Coca Cola",
                     LanguageId = "vi-VN",
                     SeoAlias = "coca-cola",
                     SeoDescription = "Sản phẩm nước uống có gas",
                     SeoTitle = "Sản phẩm nước uống có gas",
                     Details = "Sản phẩm nước uống có gas",
                     Description = "Sản phẩm nước uống có gas"
                 },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Coca Cola",
                        LanguageId = "en-US",
                        SeoAlias = "viet-tien-men-t-shirt",
                        SeoDescription = "Carbonated soft drinks",
                        SeoTitle = "Carbonated soft drinks",
                        Details = "Carbonated soft drinks",
                        Description = "Carbonated soft drinks"
                    });
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
        }


    }

}

