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
    public class SalesHistoryRepository : IRepository<SalesHistory>
    {
        private readonly AppDbContext _context;

        public SalesHistoryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<SalesHistory>> GetAll()
        {
            return await _context.SalesHistory.ToListAsync();
        }

        public async Task<SalesHistory> GetById(int id)
        {
            return await _context.SalesHistory.FindAsync(id);
        }

        public async Task Add(SalesHistory entity)
        {
            await _context.SalesHistory.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(SalesHistory entity)
        {
            _context.SalesHistory.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var sale = await _context.SalesHistory.FindAsync(id);

            if (sale != null)
            {
                _context.SalesHistory.Remove(sale);
                await _context.SaveChangesAsync();
            }
        }
    }
}
