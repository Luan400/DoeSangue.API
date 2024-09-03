using DoeSangue.Core.Entities;
using DoeSangue.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Infrastructure.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DoeSangueDbContext _dbContext;


        public UnitOfWork(DoeSangueDbContext dbContext,
            IBloodStockRepository bloodStockRepository, IDonationRepository donationRepository, IDonorsRepository donorsRepository)
        {
            _dbContext = dbContext;
            BloodStockRepository = bloodStockRepository;
            DonationRepository = donationRepository;
            DonorsRepository = donorsRepository;
        }

       
        public IBloodStockRepository BloodStockRepository { get; }

        public IDonationRepository DonationRepository { get; }

        public IDonorsRepository DonorsRepository { get; }

        public async Task AddAsync(Donation donation)
        {
           await _dbContext.AddAsync(donation);
        }

        public async Task<int> CompleteAsync()
        {
         return await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
