using CleanArchitectureGraphQl.Appplication.Book.Commands.CreateBook;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureGraphQl.Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController(IMediator mediator) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Create(CreateBookCommand command)
        {
            var result = await mediator.Send(command);
            return Ok(result);
        }
    }
}
