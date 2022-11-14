using System;
using condominiodev_api.DTOs;
using condominiodev_api.Interfaces.Service;
using condominiodev_api.Model;
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

        [HttpGet]
        public IActionResult ListAll(
            [FromQuery] string nome,
            [FromQuery] int id)
        {
            try
            {
                return Ok(_habitanteService.ListAll(nome, id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{id}/busca")]
        public IActionResult GetById([FromRoute] int id)
        {
            try
            {
               return Ok (_habitanteService.GetById(id));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("{month}/busca")]
        public IActionResult GetByMonth([FromRoute] int mes)
        {
            try
            {
               return Ok (_habitanteService.GetByMonth(mes));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("{name}/busca/nome")]
        public IActionResult GetByName([FromRoute] string name)
        {
            try
            {
                return Ok(_habitanteService.GetByName(name));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost("cadastrar")]
        public IActionResult Insert (HabitanteDTO habitante)
        {
            try
            {
                _habitanteService.Insert(habitante);
            }
            catch
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            return Ok();
        }

        [HttpPut("{id}/atualizar")]
        public IActionResult Update (int id, [FromBody] HabitanteDTO habitante)
        {
            try
            {
                habitante.Id = id;
                _habitanteService.Update(habitante);
            }
            catch
            {
                return StatusCode(StatusCodes.Status201Created);
            }
            return Ok();
        }

        [HttpDelete("{id}/deletar")]
        public IActionResult Delete ([FromRoute] int id)
        {
            try
            {
                _habitanteService.Delete(id);
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}


