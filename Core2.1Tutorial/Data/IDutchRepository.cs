using System.Collections.Generic;
using DutchTreat.Data.Entities;

namespace Core2._1Tutorial.Data
{
    //We want this interface during testing for a mockup
    public interface IDutchRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(string category);
    }
}