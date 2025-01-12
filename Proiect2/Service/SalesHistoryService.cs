using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proiect2.Entity;
using Proiect2.Repository;

namespace Proiect2.Service
{
    public class SalesHistoryService
    {
        private readonly IRepository<SalesHistory> _repository;

        public SalesHistoryService(IRepository<SalesHistory> repository)
        {
            _repository = repository;
        }

        public async Task<List<SalesHistory>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<SalesHistory> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Add(SalesHistory salesHistory)
        {
            await _repository.Add(salesHistory);
        }

        public async Task Update(SalesHistory salesHistory)
        {
            await _repository.Update(salesHistory);
        }

        public async Task Delete(int id)
        {
            await _repository.Delete(id);
        }
    }
}
