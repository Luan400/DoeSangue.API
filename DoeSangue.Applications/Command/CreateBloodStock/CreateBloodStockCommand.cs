using DoeSangue.Infrastructure.Persistence;
using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Command.CreateBloodStock
{
  
    public class CreateBloodStockCommand : IRequest<int>
    {
        public CreateBloodStockCommand(string tipoSanguineo, string fatorRh, int quantidadeML)
        {
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            QuantidadeML = quantidadeML;
        }

        public string TipoSanguineo { get; set; }

        public string FatorRh { get; set; }

        public int QuantidadeML { get; set; }
    }
}
