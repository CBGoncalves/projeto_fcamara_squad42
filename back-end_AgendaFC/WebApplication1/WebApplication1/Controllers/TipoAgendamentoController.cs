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
    public class TipoAgendamentoController : ControllerBase
    {
        private ITipoAgendamentoRepository _tipoAgendamentoRepository;


        public TipoAgendamentoController()
        {
            _tipoAgendamentoRepository = new TipoAgendamentoRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tipoAgendamentoRepository.ListarTiposAgendamento());
        }

        [HttpPost]
        public IActionResult Post(TipoAgendamento novoTipoAgendamento)
        {
            _tipoAgendamentoRepository.CadastrarTipoAgendamento(novoTipoAgendamento);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, TipoAgendamento tipoAgendamentoAtualizado)
        {
            _tipoAgendamentoRepository.AtualizarTipoAgendamentoPorId(id, tipoAgendamentoAtualizado);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tipoAgendamentoRepository.DeletarTipoAgendamento(id);

            return StatusCode(204);
        }
    }
}
