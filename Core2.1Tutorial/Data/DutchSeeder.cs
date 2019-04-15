using Core2._1Tutorial.Data.Entities;
using Microsoft.AspNetCore.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core2._1Tutorial.Data
{
    public class DutchSeeder
    {
        private readonly DutchContext _ctx;
        private readonly IHostingEnvironment _hosting;

        /// <summary>
        /// Constructor for seeder. Only called on migrations
        /// </summary>
        /// <param name="ctx">The context object that communicates with the database</param>
        /// <param name="hosting">The environment the application lives in</param>
        public DutchSeeder(DutchContext ctx, IHostingEnvironment hosting)
        {
            _ctx = ctx;
            _hosting = hosting;
        }

        public void Seed()
        {
            //Create database and tables if it does not exist
            //BEST PRACTICE
            _ctx.Database.EnsureCreated();

            if (!_ctx.Products.Any())
            {
                var filePath = Path.Combine(_hosting.ContentRootPath, "Data/art.json");
                var json = File.ReadAllText(filePath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
                _ctx.Products.AddRange(products);

                var order = _ctx.Orders.FirstOrDefault(o => o.Id == 1);
                if (order != null)
                {
                    order.Items = new List<OrderItem>()
                    {
                        new OrderItem()
                        {
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice=products.First().Price
                        }
                    };
                }

                _ctx.SaveChanges();
            }

        }
    }
}
