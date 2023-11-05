using learningReactWithAspDotNet.Models;
using learningReactWithAspDotNet.Utilities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace learningReactWithAspDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmojiController : ControllerBase
    {
        private readonly ILogger<EmojiController> _logger;
        private IEnumerable<Emoji> emojis = Enumerable.Empty<Emoji>();

        public EmojiController(ILogger<EmojiController> logger)
        {
            this._logger = logger;
            EmojiJsonReader.LoadJson(emojis);
        }

        // GET: api/<EmojiController>
        [HttpGet]
        public IEnumerable<Emoji> GetEmojis() {
            return emojis;
        }

        // GET api/<EmojiController>/abc
        [HttpGet("{name}")]
        public Task<ActionResult<Emoji>> GetEmoji(String name)
        {
            _logger.Log(LogLevel.Information, "I'm a logger!!!");
            return Task.FromResult<ActionResult<Emoji>>(emojis.FirstOrDefault(x => x.name.ToLower().Equals(name.ToLower())));
        }

        //// POST api/<EmojiController1>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<EmojiController1>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<EmojiController1>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
