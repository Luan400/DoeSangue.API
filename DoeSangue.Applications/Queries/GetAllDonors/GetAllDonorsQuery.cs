using DoeSangue.Applications.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetAllDonors
{
    public class GetAllDonorsQuery : IRequest<List<DonorsViewModel>>
    {
        public GetAllDonorsQuery(string query)
        {
            Query = query;
        }

        public string Query { get; set; }
    }
}
