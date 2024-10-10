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
        private readonly IUnitOfWork _unitOfWork;
        public CreateBloodStockCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(CreateBloodStockCommand request, CancellationToken cancellationToken)
        {
            var bloodstock = new BloodStock(request.TipoSanguineo, request.FatorRh, request.QuantidadeML);

            await _unitOfWork.AddAsync(bloodstock);

            await _unitOfWork.CompleteAsync();

            return bloodstock.Id;
        }
    }
}
