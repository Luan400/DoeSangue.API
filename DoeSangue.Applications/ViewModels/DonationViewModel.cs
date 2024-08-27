using DoeSangue.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.ViewModels
{
    public class DonationViewModel
    {
        public DonationViewModel(int donorId, DateTime dataDoacao, int quantidadeML, Donor donor)
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
    }
}
