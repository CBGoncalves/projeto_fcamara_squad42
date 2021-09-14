using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class TipoAgendamentoRepository : ITipoAgendamentoRepository
    {

        AgendaFCContext ctx = new AgendaFCContext();

        public void AtualizarTipoAgendamentoPorId(int id, TipoAgendamento tipoAgendamentoAtualizado)
        {
            TipoAgendamento tipoAgendamentoBuscado = ctx.TipoAgendamentos.Find(id);

            tipoAgendamentoBuscado.TituloTipoAgendamento = tipoAgendamentoAtualizado.TituloTipoAgendamento;

            ctx.TipoAgendamentos.Update(tipoAgendamentoBuscado);

            ctx.SaveChanges();
        }

        public void CadastrarTipoAgendamento(TipoAgendamento novoTipoAgendamento)
        {
            ctx.TipoAgendamentos.Add(novoTipoAgendamento);

            ctx.SaveChanges();
        }

        public void DeletarTipoAgendamento(int id)
        {
            TipoAgendamento tipoAgendamentoBuscado = ctx.TipoAgendamentos.Find(id);

            ctx.TipoAgendamentos.Remove(tipoAgendamentoBuscado);

            ctx.SaveChanges();
        }

        public List<TipoAgendamento> ListarTiposAgendamento()
        {
            return ctx.TipoAgendamentos.ToList();
        }
    }
}
