using System;
using System.Collections.Generic;
using mvc.Database;
using mvc.Database.Entities;

namespace razor.Database
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            var currencies = new List<CryptoCurrency>
            {
                new CryptoCurrency
                {
                    Name = "BitCoin",
                    Prices = new List<Price>
                    {
                        new Price(12, new DateTime(2017, 1,1)),
                        new Price(14, new DateTime(2017, 2,1)),
                        new Price(19, new DateTime(2017, 3,1)),
                        new Price(13,new DateTime(2017, 4,1))
                    }
                },
                new CryptoCurrency
                {
                    Name = "LiteCoint",
                      Prices = new List<Price>
                    {
                        new Price(12, new DateTime(2017, 1,1)),
                        new Price(14, new DateTime(2017, 2,1)),
                        new Price(19, new DateTime(2017, 3,1)),
                        new Price(13,new DateTime(2017, 4,1))
                    }
                }
            };
            context.CryptoCurrencies.AddRange(currencies);
            context.SaveChanges();
            
            //context.Database.Migrate();
        }
    }
}
