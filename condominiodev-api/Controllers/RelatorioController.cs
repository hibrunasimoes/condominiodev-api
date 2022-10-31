using System;
using condominiodev_api.Interfaces.Service;
using Microsoft.AspNetCore.Mvc;

namespace condominiodev_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RelatorioController : ControllerBase
    {
        private readonly IHabitanteService _habitanteService;

        public RelatorioController(IHabitanteService habitanteService)
        {
            _habitanteService = habitanteService;
        }

        [HttpGet]
        public IActionResult GetMaiorCusto()
        {
            try
            {
                return Ok(_habitanteService.GetMaiorCusto());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}

