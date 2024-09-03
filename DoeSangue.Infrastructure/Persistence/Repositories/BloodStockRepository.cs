using DoeSangue.Core.Entities;
using DoeSangue.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Infrastructure.Persistence.Repositories
{
    public class BloodStockRepository : IBloodStockRepository
    {

        private readonly DoeSangueDbContext _dbContext;
        public BloodStockRepository(DoeSangueDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<BloodStock>> AddAsync(BloodStock bloodStock)
        {
            await _dbContext.BloodStock.AddAsync(bloodStock);

            await _dbContext.SaveChangesAsync();

            return await _dbContext.BloodStock.ToListAsync();
        }

        public async Task<List<BloodStock>> GetAllAsync()
        {
            return await _dbContext.BloodStock.ToListAsync();
        }

        
    }
}
