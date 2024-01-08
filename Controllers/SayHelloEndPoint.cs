
using Microsoft.AspNetCore.Mvc;

namespace NguyenTSayHelloEndPoint.Controllers;

[ApiController]
[Route("controller")]
    public class SayHelloEndPoint : ControllerBase
    {
        [HttpGet]
        [Route("SayHell/{name}")]
        public string SayHello(string name)
        {
            return $"Hello {name}! You look great today!";
        }

    }
