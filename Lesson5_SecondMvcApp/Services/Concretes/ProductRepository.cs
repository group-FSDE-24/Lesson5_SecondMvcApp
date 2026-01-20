using Lesson5_SecondMvcApp.Helpers;
using Lesson5_SecondMvcApp.Models;
using Lesson5_SecondMvcApp.Services.Abstracts;

namespace Lesson5_SecondMvcApp.Services.Concretes;

public class ProductRepository : IRepository
{
    public List<Product> Products;

    public ProductRepository()
    {
        Products = ProductHelper.GetAllProduct();
    }

    public bool Add(Product product)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Product GetProductById(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProductsByPrice(decimal price)
    {
        throw new NotImplementedException();
    }

    public bool Remove(Guid id)
    {
        throw new NotImplementedException();
    }
}
