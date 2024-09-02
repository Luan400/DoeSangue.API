using DoeSangue.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Domain.Repositories
{
    public interface IDonationRepository
    {
        Task<List<Donation>> GetAllAsync();

        Task<List<BloodStock>> GetByIdAsync();
        Task<List<BloodStock>> AddAsync(Donation donation);
    }
}
