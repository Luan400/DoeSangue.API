using DoeSangue.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Domain.Repositories
{
    public interface IBloodStockRepository
    {
        Task<List<BloodStock>> GetAll();
    }
}
