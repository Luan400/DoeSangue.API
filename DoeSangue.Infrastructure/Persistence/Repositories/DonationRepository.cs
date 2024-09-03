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
    public class DonationRepository : IDonationRepository
    {
        private readonly DoeSangueDbContext _dbContext;
        public DonationRepository(DoeSangueDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Donation>> AddAsync(Donation donation)
        {
            await _dbContext.Donation.AddAsync(donation);

             await _dbContext.SaveChangesAsync();

            return await _dbContext.Donation.ToListAsync();
        }

        public async Task<List<Donation>> GetAllAsync()
        {
            return await _dbContext.Donation.ToListAsync();
        }

        public async Task<Donation> GetByIdAsync(int id)
        {
            return await _dbContext.Donation.SingleOrDefaultAsync(x => x.Id == id);
        }
    }
}
