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

        [HttpGet("gasto-total")]
        public IActionResult GetTotalSpend()
        {
            try
            {
                return Ok(_habitanteService.GetTotalSpend());
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("orgamento-condominio")]
        public IActionResult TotalBudget ()
        {
            try
            {
                return Ok(_habitanteService.TotalBudget());
            }
            catch
            {
                return StatusCode(StatusCodes.Status200OK);
            }
        }
        [HttpGet("diferenca-orcamentos")]
        public IActionResult BetweenBudgetAndExpense ()
        {
            return Ok(_habitanteService.BetweenBudgetAndExpense());
        }
        
    }
}

