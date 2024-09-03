using DoeSangue.Applications.Command.CreateDonor;
using DoeSangue.Applications.Command.DeleteDonor;
using DoeSangue.Applications.Queries.GetAllDonors;
using DoeSangue.Applications.Queries.GetBloodStock;

using DoeSangue.Applications.Queries.GetDonorsById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DoeSangue.API.Controllers
{
    [Route("api/donors")]


    public class DonorsController : ControllerBase
    {

        private readonly IMediator _mediator;
        public DonorsController(IMediator mediator)
         {
                _mediator = mediator;
        }
            [HttpGet]



        public async Task<IActionResult> Get(string query)
        {
            var getAll = new GetAllDonorsQuery(query);

            var id = await _mediator.Send(getAll);

            return Ok(id);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            var getAll = new GetDonorsByIdQuery(id);
            var get = await _mediator.Send(id);
            return Ok(get);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateDonorCommand command)
        {
           var id = await _mediator.Send(command);

            return Ok(id);
        }

        [HttpDelete("{id}")]

        public async  Task<IActionResult> Delete(int id)
        {
           var command = new DeleteDonorCommand(id);
            
            var result = await _mediator.Send(command);

            return Ok(result);
        }

    }
}
