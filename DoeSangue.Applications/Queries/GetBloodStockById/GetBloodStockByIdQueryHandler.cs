using DoeSangue.Applications.ViewModels;
using DoeSangue.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetBloodStockById
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
            var bloodStock = await _unitOfWork.BloodStockRepository.GetByIdAsync();

            if (bloodStock == null) return null;

            var bloodStockViewModel = bloodStock.Select(
                            p => new BloodStockViewModel(p.TipoSanguineo, p.FatorRh, p.QuantidadeML)).ToList();
            return bloodStockViewModel;

        }

    }
}
