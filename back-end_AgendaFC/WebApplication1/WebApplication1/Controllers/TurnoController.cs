using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TurnoController : ControllerBase
    {
        private ITurnoRepository _turnoRepository;


        public TurnoController()
        {
            _turnoRepository = new TurnoRepository();
        }

        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_turnoRepository.ListarTurnos());
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Post(Turno novoTurno)
        {
            _turnoRepository.CadastrarTurno(novoTurno);

            return StatusCode(201);
        }

        [Authorize(Roles = "1")]
        [HttpPut("{id}")]
        public IActionResult Put(int id, Turno turnoAtualizado)
        {
            _turnoRepository.AtualizarTurnoPorId(id, turnoAtualizado);

            return StatusCode(204);
        }

        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _turnoRepository.DeletarTurno(id);

            return StatusCode(204);
        }
    }
}
