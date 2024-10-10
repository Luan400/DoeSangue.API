using DoeSangue.Applications.ViewModels;
using DoeSangue.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetDonationById
{
    public class GetDonationByIdQueryHandler : IRequestHandler<GetDonationByIdQuery, List<DonationViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetDonationByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<DonationViewModel>> Handle(GetDonationByIdQuery request, CancellationToken cancellationToken)
        {
            var donation = await _unitOfWork.DonationRepository.GetByIdAsync(request.Id);

            if (donation == null)
            {
                return null;
            }

            var donationViewModel = new DonationViewModel(
                donation.DonorId,
                donation.DataDoacao,
                donation.QuantidadeML,
                donation.Donor
                );
             
            return new List<DonationViewModel> { donationViewModel};
        }
    }
}
