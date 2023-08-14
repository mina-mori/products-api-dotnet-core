using System;
using System.Collections.Generic;

namespace ProductsAPI.Services
{
    public interface IProductsService
    {
        public List<Product> GetProducts();

        public Product AddProduct(Product productItem);

        public Product UpdateProduct(int id, Product productItem);

        public int DeleteProduct(int id);
    }
}
