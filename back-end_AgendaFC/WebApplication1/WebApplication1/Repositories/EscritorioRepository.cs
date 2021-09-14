using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class EscritorioRepository : IEscritorioRepository
    {

        AgendaFCContext ctx = new AgendaFCContext();
        
        public void AtualizarEscritorioPorId(int id, Escritorio escritorioAtualizado)
        {
            Escritorio escritorioBuscado = ctx.Escritorios.Find(id);

            escritorioBuscado.TituloEscritorio = escritorioAtualizado.TituloEscritorio;

            escritorioBuscado.EnderecoEscritorio = escritorioAtualizado.EnderecoEscritorio;

            ctx.Escritorios.Update(escritorioBuscado);

            ctx.SaveChanges();
        }

        public void CadastrarEscritorio(Escritorio novoEscritorio)
        {
            ctx.Escritorios.Add(novoEscritorio);

            ctx.SaveChanges();
        }

        public void DeletarEscritorio(int id)
        {
            Escritorio escritorioBuscado = ctx.Escritorios.Find(id);

            ctx.Escritorios.Remove(escritorioBuscado);

            ctx.SaveChanges();
        }

        public List<Escritorio> ListarEscritorios()
        {
            return ctx.Escritorios.ToList();
        }
    }
}
