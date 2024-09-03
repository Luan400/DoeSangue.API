using DoeSangue.Core.Entities;
using DoeSangue.Infrastructure.Persistence;
using MediatR;
using MediatR.Pipeline;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Command.CreateDonation
{
    public class CreateDonationCommandHandler : IRequestHandler<CreateDonationCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateDonationCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(CreateDonationCommand request, CancellationToken cancellationToken)
        {
            var donation = new Donation(request.DonorId, request.QuantidadeML);

            await _unitOfWork.AddAsync(donation);

            await _unitOfWork.SaveChangesAsync();

            return donation.Id;
        }
    }
}
