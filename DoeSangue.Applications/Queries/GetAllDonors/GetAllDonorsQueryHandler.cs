using DoeSangue.Applications.ViewModels;
using DoeSangue.Domain.Repositories;
using DoeSangue.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetAllDonors
{
    public class GetAllDonorsQueryHandler : IRequestHandler<GetAllDonorsQuery, List<DonorsViewModel>>
    {

        private readonly IUnitOfWork _unitOfWork;
        public GetAllDonorsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<DonorsViewModel>> Handle(GetAllDonorsQuery request, CancellationToken cancellationToken)
        {
            var donors = await _unitOfWork.DonorsRepository.GetAllAsync();

            var donorViewModel = donors.Select(
                p=> new DonorsViewModel(p.NomeCompleto, p.Email, p.DataNascimento, p.Genero, p.Peso, p.TipoSanguineo, p.FatorRh)).ToList();

            return donorViewModel;
        }
    }
}
