using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsAuthority.Models
{
    public class FakeProductRepostiory : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
        new Product { Name = "Simon Signature Model Football", Price = 25 },
        new Product { Name = "Surfboard", Price = 179 },
        new Product { Name = "Running Shoes", Price = 95 },
        }.AsQueryable<Product>();
    }
}
