using DoeSangue.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Infrastructure.Persistence
{
    public interface IUnitOfWork
    {
        IBloodStockRepository BloodStockRepository { get; }
        IDonationRepository DonationRepository { get; }

        IDonorsRepository DonorsRepository { get; }

        Task<int> CompleteAsync();
    }
}
