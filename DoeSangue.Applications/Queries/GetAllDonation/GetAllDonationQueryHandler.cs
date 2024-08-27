using DoeSangue.Applications.ViewModels;
using DoeSangue.Domain.Repositories;
using DoeSangue.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetAllDonation
{
    public class GetAllDonationQueryHandler : IRequestHandler<GetAllDonationQuery, List<DonationViewModel>>
    {

        private readonly IUnitOfWork _unitOfWork;
        public GetAllDonationQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<DonationViewModel>> Handle(GetAllDonationQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
