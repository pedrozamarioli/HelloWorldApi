using Microsoft.AspNetCore.Mvc;

namespace HelloWorldApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            var localIpAddress = HttpContext.Connection.LocalIpAddress;
            var localPort = HttpContext.Connection.LocalPort;
            return $"Hello World\nIp address: {localIpAddress}\nPort: {localPort}";
        }
    }
}
