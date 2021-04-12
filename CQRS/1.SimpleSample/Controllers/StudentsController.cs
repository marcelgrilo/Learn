using CQRS.SimpleSample.Domain.Commands;
using Microsoft.AspNetCore.Mvc;
using CQRS.SimpleSample.Domain.Handlers;
using CQRS.SimpleSample.Domain.Queries;

namespace CQRS.SimpleSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public IActionResult GetById(
            [FromServices] IFindStudentByIdQueryHandler handler,
            [FromQuery] FindStudentByIdQuery query
        )
        {
            var result = handler.Handle(query);
            return Ok(result);
        }

        [HttpPost]
        [Route("")]
        public IActionResult CreateStudent(
            [FromServices] ICreateStudentCommandHandler handler,
            [FromBody] CreateStudentCommand createStudentCommand
        ) {
            var result = handler.Handle(createStudentCommand);
            return Ok(result);
        }
    }
}