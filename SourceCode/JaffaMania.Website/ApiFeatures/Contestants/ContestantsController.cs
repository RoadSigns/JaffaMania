using System.Threading.Tasks;
using JaffaMania.Website.ApiFeatures.Contestants.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JaffaMania.Website.ApiFeatures.Contestants
{

    [Route("api/[controller]")]
    public class ContestantsController : Controller
    {
        public ContestantsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        //
        //  Methods:  Controller Actions

        [HttpGet]
        public async Task<IActionResult> GetAllContestants()
        {
            var getAllContestantsQuery = new GetAllContestantsQuery();

            var getAllContestantsResult = await _mediator.Send(getAllContestantsQuery);

            return  getAllContestantsResult == null || getAllContestantsResult.Count > 0
                ? Ok(getAllContestantsResult)
                : NotFound() as IActionResult;
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetContestantById(string id)
        {
            var getContestantByIdQuery = new GetContestantByIdQuery(id);

            if (!getContestantByIdQuery.IsValid())
            {
                return BadRequest("BadRequest:  Guid Expected");
            }

            var getContestantByIdResult = await _mediator.Send(getContestantByIdQuery);

            if(getContestantByIdResult !=null)
                return Ok(getContestantByIdResult);
            else
            {
                return NotFound();
            }
 
        }


        [HttpGet("{id}/attempts")]
        public async Task<IActionResult> GetContestantsAttempts(string id)
        {
            var getContestantAttemptsQuery = new GetContestantAttemptsQuery(id);

            if (!getContestantAttemptsQuery.IsValid())
            {
                return BadRequest("BadRequest:  Guid Expected");
            }

            var getContestantAttemptsResult = await _mediator.Send(getContestantAttemptsQuery);

            return getContestantAttemptsResult == null || getContestantAttemptsResult.Count > 0
                ? Ok(getContestantAttemptsResult)
                : NotFound() as IActionResult;
        }


        //
        //  Fields
        private readonly IMediator _mediator;
    }
}