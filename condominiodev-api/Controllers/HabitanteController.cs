﻿using System;
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

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            try
            {
                _habitanteService.GetById(id);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok();
        }

        [HttpGet("{month}")]
        public IActionResult GetByMonth([FromRoute] int month)
        {
            try
            {
                _habitanteService.GetByMonth(month);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            return Ok();
        }

        [HttpPost("insert")]
        public IActionResult Insert ([FromBody] HabitanteDTO habitante)
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

        [HttpPut("{id}")]
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

        [HttpDelete("{id}")]
        public IActionResult Delete ([FromRoute] int id)
        {
            try
            {
                _habitanteService.Delete(id);
                return StatusCode(StatusCodes.Status204NoContent);
            }
            catch
            {
                return StatusCode(StatusCodes.Status201Created);
            }
        }
    }
}


