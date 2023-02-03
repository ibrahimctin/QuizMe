
namespace QuizMe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoicesController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ChoicesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("CreateChoice")]
        public async Task<IActionResult> Post([FromBody] CreateChoiceRequest request)
        {
            var command = new CreateChoiceCommand { CreateChoiceRequest = request };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var command = new DeleteChoiceCommand { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }


        [HttpPost("UpdateChoice")]
        public async Task<IActionResult> Update([FromBody] UpdateChoiceRequest request, string id)
        {
            var command = new UpdateChoiceCommand { UpdateChoiceRequest = request, Id = id };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }



    }
}
