using DoeSangue.Applications.Command.CreateBloodStock;
using DoeSangue.Applications.Command.UpdateBloodStock;
using DoeSangue.Applications.Queries.GetBloodStock;
using DoeSangue.Applications.Queries.GetBloodStockById;
using MediatR;

using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DoeSangue.API.Controllers
{
    [Route("api/bloodstock")]
    public class BloodStockController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BloodStockController(IMediator mediator) {
        _mediator = mediator;
        }


        [HttpGet]

        public async Task<IActionResult> Get(string query)
        {
            var getAll = new GetAllBloodStockQuery(query);

            var id = await _mediator.Send(getAll);

            return Ok(id);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {

            var getAll = new GetBloodStockByIdQuery(id);

            var get = await _mediator.Send(id);

            return Ok(get);
        }

        [HttpPost]

        public  async Task<IActionResult> Post([FromBody] CreateBloodStockCommand command)
        {
           var id = await _mediator.Send(command);

            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put (int id, [FromBody] UpdateBloodStockCommand command)
        {
             await _mediator.Send(command);

            return Ok(id);
        }

    }
}