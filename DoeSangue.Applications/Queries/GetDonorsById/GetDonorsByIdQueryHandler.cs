using DoeSangue.Applications.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetDonorsById
{
    public class GetDonorsByIdQueryHandler : IRequestHandler<GetDonorsByIdQuery, List<DonorsViewModel>>
    {
        public Task<List<DonorsViewModel>> Handle(GetDonorsByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
