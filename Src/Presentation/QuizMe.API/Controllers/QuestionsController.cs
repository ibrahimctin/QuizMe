


namespace QuizMe.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public QuestionsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpPost("CreateQuestion")]
        public async Task<IActionResult> Post([FromBody] CreateQuestionRequest request)
        {
            var command = new CreateQuestionCommand { CreateQuestionRequest = request };
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }



        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var command = new DeleteQuestionCommand { Id = id };
            var response = await _mediator.Send(command);
            return Ok(response);
        }


        [HttpPost("UpdateQuestion")]
        public async Task<IActionResult> Update([FromBody] UpdateQuestionRequest request,string id)
        {
            var command = new UpdateQuestionCommand { UpdateQuestionRequest = request ,Id=id};
            var repsonse = await _mediator.Send(command);
            return Ok(repsonse);
        }

        [HttpGet("GetQuestionDetail")]
        public async Task<IActionResult> GetQuestion( string id)
            => Ok(await _mediator.Send(new GetQuestionDetailRequest { Id = id }));
    }
}
