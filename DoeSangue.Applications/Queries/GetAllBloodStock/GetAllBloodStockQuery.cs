using DoeSangue.Applications.ViewModels;
using DoeSangue.Core.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetBloodStock
{
    public class GetAllBloodStockQuery : IRequest<List<BloodStockViewModel>>
    {
       

        public GetAllBloodStockQuery(string query)
        {
            Query = query;
        }

        public string Query { get; private set; }
    }
}
