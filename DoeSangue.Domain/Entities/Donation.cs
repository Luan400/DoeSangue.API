using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Core.Entities
{
    public class Donation : BaseEntity
    {
        public Donation(int quantidadeML, int donorId)
        {
            QuantidadeML = quantidadeML;
            DonorId = donorId;
        }

        public Donation(int donorId, DateTime dataDoacao, int quantidadeML, Donor donor)
        {
            DonorId = donorId;
            DataDoacao = dataDoacao;
            QuantidadeML = quantidadeML;
            Donor = donor;
        }

        public int DonorId { get; set; }

        public DateTime DataDoacao { get; set; }

        public int QuantidadeML { get; set; }

        public Donor Donor { get; set; }

        public void Update(int quantidadeML)
        {
            QuantidadeML += quantidadeML;
        }
    }
}
