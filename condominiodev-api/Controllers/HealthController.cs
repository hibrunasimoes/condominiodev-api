using System;
using Microsoft.AspNetCore.Mvc;

namespace condominiodev_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Health()
        {
            return Ok("Health");
        }
    }
}

