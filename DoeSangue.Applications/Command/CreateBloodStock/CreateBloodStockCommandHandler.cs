using DoeSangue.Core.Entities;
using DoeSangue.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Command.CreateBloodStock
{
    public class CreateBloodStockCommandHandler : IRequestHandler<CreateBloodStockCommand, int>
    {
        private readonly DoeSangueDbContext _dbContext;
        public CreateBloodStockCommandHandler(DoeSangueDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Handle(CreateBloodStockCommand request, CancellationToken cancellationToken)
        {
            var bloodstock = new BloodStock(request.TipoSanguineo, request.FatorRh, request.QuantidadeML);

            await _dbContext.AddAsync(bloodstock);

            await _dbContext.SaveChangesAsync();

            return bloodstock.Id;
        }
    }
}
