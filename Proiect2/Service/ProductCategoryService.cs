using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect2.Entity;
using Proiect2.Repository;

namespace Proiect2.Service
{
    public class ProductCategoryService
    {
        private readonly IRepository<ProductCategory> _repository;

        public ProductCategoryService(IRepository<ProductCategory> repository)
        {
            _repository = repository;
        }

        public async Task<List<ProductCategory>> GetAllProductCategories()
        {
            return await _repository.GetAll();
        }

        public async Task<ProductCategory> GetProductCategoryById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task AddProductCategory(ProductCategory category)
        {
            await _repository.Add(category);
        }

        public async Task UpdateProductCategory(ProductCategory category)
        {
            await _repository.Update(category);
        }

        public async Task DeleteProductCategory(int id)
        {
           await _repository.Delete(id);
        }
    }
}
