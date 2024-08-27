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
        private readonly DoeSangueDbContext _dbContext;
        public CreateDonorCommandHandler(DoeSangueDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> Handle(CreateDonorCommand request, CancellationToken cancellationToken)
        {
            var donor = new Donor(request.NomeCompleto, request.Email, request.DataNascimento, request.Genero, request.Peso, request.TipoSanguineo, request.FatorRh); ;

            await _dbContext.AddAsync(donor);

            await _dbContext.SaveChangesAsync();

            return donor.Id;
        }
    }
}
