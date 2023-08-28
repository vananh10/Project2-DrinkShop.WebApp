using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DrinkShop.Data.EF
{
    public class DrinkShopDbContextFactory : IDesignTimeDbContextFactory<DrinkShopDbcontext>
    {
        public DrinkShopDbcontext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DrinkShopDb");

            var optionsBuilder = new DbContextOptionsBuilder<DrinkShopDbcontext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new DrinkShopDbcontext(optionsBuilder.Options);
        }
    }
}
