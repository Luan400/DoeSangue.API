using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Core.Entities
{
    public class BloodStock : BaseEntity
    {
        public BloodStock(string tipoSanguineo, string fatorRh, int quantidadeML)
        {
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            QuantidadeML = quantidadeML;
        }

        public string TipoSanguineo { get; set; }

        public string FatorRh { get; set; }

        public int QuantidadeML { get; set; }

        public void Update(string tipoSanguineo, string fatorRh, int quantidadeML, int id)
        {
            TipoSanguineo = tipoSanguineo;
            FatorRh = fatorRh;
            QuantidadeML = quantidadeML;
        }
    }



}
