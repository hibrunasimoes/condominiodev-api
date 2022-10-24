using System;
using condominiodev_api.DTOs;
using condominiodev_api.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace condominiodev_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HabitanteController : ControllerBase
    {
        private readonly IHabitanteService _habitanteService;

        public HabitanteController (IHabitanteService habitanteService)
        {
            _habitanteService = habitanteService;
        }

        [HttpPost("Insert")]
        public IActionResult Insert([FromBody] HabitanteDTO habitante)
        {
            try
            {
                _habitanteService.Insert(habitante);
            }
            catch
            {
                return StatusCode(500);
            }
            return Ok();
        }
    }
}


