using DoeSangue.Applications.ViewModels;
using DoeSangue.Infrastructure.Persistence;
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
        private readonly IUnitOfWork _unitOfWork;
        public GetDonorsByIdQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<DonorsViewModel>> Handle(GetDonorsByIdQuery request, CancellationToken cancellationToken)
        {
            var donors = await _unitOfWork.DonorsRepository.GetAllAsync();

            var donorViewModel = donors.Select(
                p => new DonorsViewModel(p.NomeCompleto, p.Email, p.DataNascimento, p.Genero, p.Peso, p.TipoSanguineo, p.FatorRh)).ToList();

            return donorViewModel;
        }
    }
}
