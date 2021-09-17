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
    public class AgendamentoController : ControllerBase
    {
        private IAgendamentoRepository _agendamentoRepository;


        public AgendamentoController()
        {
            _agendamentoRepository = new AgendamentoRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_agendamentoRepository.ListarAgendamentos());
        }

        [HttpPost]
        public IActionResult Post(Agendamento novoAgendamento)
        {
            _agendamentoRepository.CadastrarAgendamento(novoAgendamento);

            return StatusCode(201);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_agendamentoRepository.BuscarAgendamentoPorId(id));
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Agendamento agendamentoAtualizado)
        {
            _agendamentoRepository.AtualizarAgendamentoPorId(id, agendamentoAtualizado);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _agendamentoRepository.DeletarAgendamento(id);

            return StatusCode(204);
        }
    }
}
