﻿using System.Threading.Tasks;
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
            return Ok(await _mediator.Send(getAllContestantsQuery));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetContestantById()
        {
            var getContestantByIdQuery = new GetContestantByIdQuery();
            return Ok(await _mediator.Send(getContestantByIdQuery));
        }

        [HttpGet("{id}/attempts")]
        public async Task<IActionResult> GetContestantsAttempts()
        {
            var getContestantAttemptsQuery = new GetContestantAttemptsQuery();
            return Ok(await _mediator.Send(getContestantAttemptsQuery));
        }


        //
        //  Fields
        private readonly IMediator _mediator;
    }
}