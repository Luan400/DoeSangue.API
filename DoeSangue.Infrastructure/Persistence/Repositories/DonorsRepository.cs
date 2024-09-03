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
    public class DonorsRepository : IDonorsRepository
    {
        private readonly DoeSangueDbContext _dbContext;
        public DonorsRepository(DoeSangueDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Donor>> AddAsync(Donor donor)
        {
            await _dbContext.Donor.AddAsync(donor);

            await _dbContext.SaveChangesAsync();

            return await _dbContext.Donor.ToListAsync();
        }

        public async Task<List<Donor>> GetAllAsync()
        {
            return await _dbContext.Donor.ToListAsync();
        }

      public async Task<Donor> GetByIdAsync(int id)
        {
            return await _dbContext.Donor.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
