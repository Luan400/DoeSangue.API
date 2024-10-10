using DoeSangue.Applications.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoeSangue.Applications.Queries.GetDonorsById
{
    public class GetBloodStockByIdQuery : IRequest<List<BloodStockViewModel>> { 
        public GetBloodStockByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
