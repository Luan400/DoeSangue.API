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
            var donation = await _unitOfWork.DonationRepository.GetAllAsync();

            var donationViewModel = donation.Select(
                p => new DonationViewModel(p.DonorId, p.DataDoacao, p.QuantidadeML, p.Donor)).ToList();

            return donationViewModel;
        }
    }
}
