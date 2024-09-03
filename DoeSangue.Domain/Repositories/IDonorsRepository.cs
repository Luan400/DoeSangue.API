using DoeSangue.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Domain.Repositories
{
    public interface IDonorsRepository
    {
        Task<List<Donor>> GetAllAsync();

        Task<Donor> GetByIdAsync(int id);

        Task<List<Donor>> AddAsync(Donor donor);
    }
}
