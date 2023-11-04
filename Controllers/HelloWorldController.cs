using Microsoft.AspNetCore.Mvc;

namespace learningReactWithAspDotNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }
        /* https://learn.microsoft.com/en-us/aspnet/core/web-api/action-return-types?view=aspnetcore-7.0 */
        [HttpGet]
        public IEnumerable<String> Get() => new List<String> { "John", "Says", "Hi"};
    }
}
