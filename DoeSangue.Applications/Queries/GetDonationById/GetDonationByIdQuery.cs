using DoeSangue.Applications.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetDonationById
{
    public class GetDonationByIdQuery : IRequest<List<DonationViewModel>>
    {
        public GetDonationByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
