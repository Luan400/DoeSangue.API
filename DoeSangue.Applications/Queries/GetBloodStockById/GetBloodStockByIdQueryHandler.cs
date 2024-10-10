using DoeSangue.Applications.Queries.GetDonorsById;
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
    public class GetBloodStockByIdQueryHandler : IRequestHandler<GetBloodStockByIdQuery, List<BloodStockViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetBloodStockByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
 
        public async Task<List<BloodStockViewModel>> Handle(GetBloodStockByIdQuery request, CancellationToken cancellationToken)
        {
            var bloodstock = await _unitOfWork.BloodStockRepository.GetByIdAsync(request.Id);


            if (bloodstock == null)
            {
                return null; 
            }

      
            var bloodStockViewModel = new BloodStockViewModel(
                bloodstock.TipoSanguineo,
                bloodstock.FatorRh,
                bloodstock.QuantidadeML
               );

            return new List<BloodStockViewModel> { bloodStockViewModel };
        }
    }
}
