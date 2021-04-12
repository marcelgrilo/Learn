using CQRS.SimpleSample.Domain.Commands;
using Microsoft.AspNetCore.Mvc;
using CQRS.SimpleSample.Domain.Queries;
using MediatR;

namespace CQRS.SimpleSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetById(
            [FromServices] IMediator mediator,
            [FromQuery] FindStudentByIdQuery query
        )
        {
            var result = mediator.Send(query);
            return Ok(result.Result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateStudent(
            [FromServices] IMediator mediator,
            [FromBody] CreateStudentCommand createStudentCommand
        ) {
            var result = mediator.Send(createStudentCommand);
            return Ok(result);
        }
    }
}