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
        private readonly IUnitOfWork _unitOfWork;
        public UpdateBloodStockCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Handle(UpdateBloodStockCommand request, CancellationToken cancellationToken)
        {
            var bloodStock = await _unitOfWork.BloodStockRepository.GetByIdAsync(request.Id);

            if (bloodStock == null)
            {
                bloodStock.Update(request.TipoSanguineo, request.FatorRh, request.QuantidadeML, request.Id);

                await _unitOfWork.UpdateAsync(bloodStock);

            }
            return bloodStock?.Id ?? 0;
        }
    }
}
