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
    public class EscritorioController : ControllerBase
    {
        private IEscritorioRepository _escritorioRepository;


        public EscritorioController()
        {
            _escritorioRepository = new EscritorioRepository();
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_escritorioRepository.ListarEscritorios());
        }

        [HttpPost]
        public IActionResult Post(Escritorio novoEscritorio)
        {
            _escritorioRepository.CadastrarEscritorio(novoEscritorio);

            return StatusCode(201);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Escritorio escritorioAtualizado)
        {
            _escritorioRepository.AtualizarEscritorioPorId(id, escritorioAtualizado);

            return StatusCode(204);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _escritorioRepository.DeletarEscritorio(id);

            return StatusCode(204);
        }
    }
}
