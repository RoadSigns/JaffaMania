using System.Threading.Tasks;
using JaffaMania.Website.ApiFeatures.LeaderBoard.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace JaffaMania.Website.ApiFeatures.LeaderBoard
{
    [Route("api/[controller]")]
    public class LeaderBoardController : Controller
    {
        public LeaderBoardController(IMediator mediator)
        {
            _mediator = mediator;
        }


        //
        //  Methods:  Controller Actions

        [HttpGet]
        public async Task<IActionResult> GetLeaderBoard()
        {
            var getAllLeaderBoardPositionsQuery = new GetAllLeaderBoardPositionsQuery();
            return Ok(await _mediator.Send(getAllLeaderBoardPositionsQuery));
        }


        //
        //  Fields
        private readonly IMediator _mediator;
    }
}