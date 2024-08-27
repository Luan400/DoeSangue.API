using DoeSangue.Applications.ViewModels;
using DoeSangue.Domain.Repositories;
using DoeSangue.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetBloodStock
{
    public class GetAllBloodStockQueryHandler : IRequestHandler<GetAllBloodStockQuery, List<BloodStockViewModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllBloodStockQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<List<BloodStockViewModel>> Handle(GetAllBloodStockQuery request, CancellationToken cancellationToken)
        {
            var bloodStock = 
        }
    }
}
