using DoeSangue.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Command.DeleteDonor
{
    public class DeleteDonorCommandHandler : IRequestHandler<DeleteDonorCommand, int>
    {

        private readonly DoeSangueDbContext _dbContext;
        public DeleteDonorCommandHandler(DoeSangueDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(DeleteDonorCommand request, CancellationToken cancellationToken)
        {
            var donor = _dbContext.Donor.SingleOrDefault(p => p.Id == request.DonorId);

            if (donor != null)
            {
                donor.Delete(false);
                await _dbContext.SaveChangesAsync();
            }

            return donor?.Id ?? 0;
        }
    }
}
