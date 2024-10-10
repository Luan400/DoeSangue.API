using DoeSangue.Core.Entities;
using DoeSangue.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Command.CreateDonor
{
    public class CreateDonorCommandHandler : IRequestHandler<CreateDonorCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        public CreateDonorCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<int> Handle(CreateDonorCommand request, CancellationToken cancellationToken)
        {
            var donor = new Donor(request.NomeCompleto, request.Email, request.DataNascimento, request.Genero, request.Peso, request.TipoSanguineo, request.FatorRh); ;

            await _unitOfWork.AddAsync(donor);

            await _unitOfWork.CompleteAsync();

            return donor.Id;
        }
    }
}
