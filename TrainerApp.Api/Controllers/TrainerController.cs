using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainerApp.Application.Commands;
using TrainerApp.Application.Queries;
using TrainerApp.Application.Responses;
using TrainerApp.Core.Entities;

namespace TrainerApp.Api.Controllers
{
   
            [Route("api/[controller]")]
            [ApiController]
            public class TrainerController : ControllerBase
            {
                private readonly IMediator _mediator;
                public TrainerController(IMediator mediator)
                {
                    _mediator = mediator;
                }

                [HttpGet]
                [ProducesResponseType(StatusCodes.Status200OK)]
                public async Task<ActionResult<List<Trainer>>> Get()
                {
                    return await _mediator.Send((new GetAllTrainersQuery()));
                }
                // public async Task<List<Trainer>> Get()
                // {
                //     return await _mediator.Send(new GetAllTrainersQuery());
                // }
                [HttpPost]
                [ProducesResponseType(StatusCodes.Status200OK)]
                public async Task<ActionResult<TrainerResponse>> CreateTrainer([FromBody] CreateTrainerCommand command)
                {
                    var result = await _mediator.Send(command);
                    return Ok(result);
                }
            }
        }
    
