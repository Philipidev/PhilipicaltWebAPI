using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhilipicaltWebAPI.Model;
using System.Text.Json;

namespace PhilipicaltWebAPI.Controllers
{
    public class LoggingController : ApiController<LoggingController>
    {
        public LoggingController(ILogger<LoggingController> logger) : base(logger)
        {

        }

        [HttpGet("api/[controller]/Get")]
        public void Get()
        {
            logger.LogInformation("oioioioi loguei aqui");
        }

        [HttpPost("api/[controller]/Post")]
        public void Post(TestePostInput input)
        {
            logger.LogInformation(JsonSerializer.Serialize(input));
        }
    }
}
