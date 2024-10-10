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

        private readonly IUnitOfWork _unitOfWork;
        public DeleteDonorCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(DeleteDonorCommand request, CancellationToken cancellationToken)
        {
            var donor = await _unitOfWork.DonorsRepository.GetByIdAsync(request.DonorId);

            if (donor != null)
            {
                donor.Delete(false);
                await _unitOfWork.CompleteAsync();

            }

            return donor?.Id ?? 0;
        }
    }
}
