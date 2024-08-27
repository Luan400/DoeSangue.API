using DoeSangue.Applications.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetAllDonation
{
    public class GetAllDonationQuery : IRequest<List<DonationViewModel>>
    {
        public GetAllDonationQuery(string query)
        {
            Query = query;
        }

        public string Query { get; set; }
    }
}
