using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Command.DeleteDonor
{
    public class DeleteDonorCommand : IRequest<int>
    {
        public DeleteDonorCommand(int donorId)
        {
            DonorId = donorId;
        }

        public int DonorId { get; set; }
    }
}
