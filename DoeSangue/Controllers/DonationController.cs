using DoeSangue.Applications.Command.CreateDonation;
using DoeSangue.Applications.Queries.GetAllDonation;
using DoeSangue.Applications.Queries.GetBloodStock;
using DoeSangue.Applications.Queries.GetBloodStockById;
using DoeSangue.Applications.Queries.GetDonationById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DoeSangue.API.Controllers
{
    [Route("api/donation")]
    public class DonationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DonationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]

        public async Task< IActionResult> Get(string query)
        {
            var getAll = new GetAllDonationQuery(query);

            var id = await _mediator.Send(getAll);

            return Ok(id);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> GetById(int id)
        {
            var getAll = new GetDonationByIdQuery(id);

            var get = await _mediator.Send(id);

            return Ok(get);
        }


        [HttpPost]
        public IActionResult Post([FromBody] CreateDonationCommand command)
        {
            return Ok();
        }
    }
}
