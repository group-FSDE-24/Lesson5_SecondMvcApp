using Lesson5_SecondMvcApp.Models;

namespace Lesson5_SecondMvcApp.Helpers;

public static class ProductHelper
{
    public static List<Product> GetAllProduct()
    {
        var products = new List<Product>()
        {
            new Product(){Id= Guid.NewGuid(), Name = "Product 1", Price = 1, Description = "Product Description 1"},
            new Product(){Id= Guid.NewGuid(), Name = "Product 2", Price = 2, Description = "Product Description 2"},
            new Product(){Id= Guid.NewGuid(), Name = "Product 3", Price = 3, Description = "Product Description 3"},
            new Product(){Id= Guid.NewGuid(), Name = "Product 4", Price = 4, Description = "Product Description 4"},
            new Product(){Id= Guid.NewGuid(), Name = "Product 5", Price = 5, Description = "Product Description 5"},
            new Product(){Id= Guid.NewGuid(), Name = "Product 6", Price = 6, Description = "Product Description 6"},
            new Product(){Id= Guid.NewGuid(), Name = "Product 7", Price = 7, Description = "Product Description 7"},
            new Product(){Id= Guid.NewGuid(), Name = "Product 8", Price = 8, Description = "Product Description 8"},
            new Product(){Id= Guid.NewGuid(), Name = "Product 9", Price = 9, Description = "Product Description 9"},
            new Product(){Id= Guid.NewGuid(), Name = "Product 10", Price = 10, Description = "Product Description 10"},
        };

        return products;
    }


}
