using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect2.Entity;
using Proiect2.Repository;

namespace Proiect2.Service
{
    public class ProductService
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _repository.GetAll();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task AddProduct(Product product)
        {
            await _repository.Add(product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _repository.Update(product);
        }

        public async Task DeleteProduct(int id)
        {
            await _repository.Delete(id);
        }

        public async Task AddProductQuantity(int productId,  int quantity)
        {
            Product product = await _repository.GetById(productId);
            if (product != null)
            {
                product.Quantity += quantity;
                _repository.Update(product);
            }
            else
            {
                throw new Exception("Product not found");
            }
        }

        public async Task SellProduct(Product product)
        {
            await _repository.Update(product);
        }
    }
}
