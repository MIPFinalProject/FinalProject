using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect2.Data;
using Proiect2.Entity;

namespace Proiect2.Repository
{
    public class ProductCategoryRepository : IRepository<ProductCategory>
    {
        private readonly AppDbContext _context;

        public ProductCategoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductCategory>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<ProductCategory> GetById(int id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task Add(ProductCategory productCategory)
        {
            await _context.Categories.AddAsync(productCategory);
            await _context.SaveChangesAsync();
        }

        public async Task Update(ProductCategory productCategory)
        {
            _context.Categories.Update(productCategory);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var productCategory = await _context.Categories.FindAsync(id);
            if (productCategory != null)
            {
                _context.Categories.Remove(productCategory);
                await _context.SaveChangesAsync();
            }
        }
    }
}
