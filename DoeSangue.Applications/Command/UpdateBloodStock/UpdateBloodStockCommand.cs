using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Command.UpdateBloodStock
{
    public class UpdateBloodStockCommand : IRequest<int>
    {

        public UpdateBloodStockCommand(string tipoSanguineo, string fatorRh, int quantidadeML, int id)
        {
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            QuantidadeML = quantidadeML;
            Id = id;
        }

        public string TipoSanguineo { get; set; }

        public string FatorRh { get; set; }

        public int QuantidadeML { get; set; }

        public int Id { get; set; }
    }
}
