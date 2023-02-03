


namespace QuizMe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuizzesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public QuizzesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("CreateQuiz")]
        public async Task<IActionResult> Post([FromBody] CreateQuizRequest request)
        {
            var command = new CreateQuizCommand { CreateQuizRequest = request };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var command = new DeleteQuizCommand { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }


        [HttpPost("UpdateQuiz")]
        public async Task<IActionResult> Update([FromBody] UpdateQuizRequest request,string id)
        {
            var command = new UpdateQuizCommand { UpdateQuizRequest = request ,Id=id};
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        [HttpGet("GetQuestDetail")]
        public async Task<IActionResult> GetQuest(string id)
          => Ok(await _mediator.Send(new GetQuizDetailRequest { Id = id }));
    }
}
