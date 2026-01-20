using Lesson5_SecondMvcApp.Models;

namespace Lesson5_SecondMvcApp.Services.Abstracts;

public interface IRepository
{
    bool Add(Product product);
    bool Remove(Guid id);
    IEnumerable<Product> GetAllProducts();
    Product GetProductById(Guid id);
    List<Product> GetProductsByPrice(decimal price);

}
