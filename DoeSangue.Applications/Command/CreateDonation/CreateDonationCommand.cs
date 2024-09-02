using DoeSangue.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Command.CreateDonation
{
    public class CreateDonationCommand : IRequest<int>
    {
        public CreateDonationCommand(int donorId, int quantidadeML)
        {
            DonorId = donorId;
            QuantidadeML = quantidadeML;
           
        }

        public int DonorId { get; set; }
        public int QuantidadeML { get; set; }

        
    }
}
