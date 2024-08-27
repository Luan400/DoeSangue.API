using DoeSangue.Infrastructure.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Command.UpdateBloodStock
{
    public class UpdateBloodStockCommandHandler : IRequestHandler<UpdateBloodStockCommand, int>
    {
        private readonly DoeSangueDbContext _dbContext;
        public UpdateBloodStockCommandHandler(DoeSangueDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(UpdateBloodStockCommand request, CancellationToken cancellationToken)
        {
            var bloodStock = _dbContext.BloodStock.SingleOrDefault(p => p.Id == request.Id);

            bloodStock.Update(request.TipoSanguineo, request.FatorRh, request.QuantidadeML, request.Id);

            await _dbContext.SaveChangesAsync();

            return bloodStock.Id;
        }
    }
}
