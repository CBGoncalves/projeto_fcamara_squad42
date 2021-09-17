using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class AgendamentoRepository : IAgendamentoRepository
    {

        AgendaFCContext ctx = new AgendaFCContext();

        public void AtualizarAgendamentoPorId(int id, Agendamento agendamentoAtualizado)
        {
            Agendamento agendamentoBuscado = ctx.Agendamentos.Find(id);

            agendamentoBuscado.DataAgendamento = agendamentoAtualizado.DataAgendamento;

            agendamentoBuscado.IdTipoAgendamento = agendamentoAtualizado.IdTipoAgendamento;

            agendamentoBuscado.IdEscritorio = agendamentoAtualizado.IdEscritorio;

            agendamentoBuscado.IdTurno = agendamentoAtualizado.IdTurno;

            ctx.Agendamentos.Update(agendamentoBuscado);

            ctx.SaveChanges();
        }

        public Agendamento BuscarAgendamentoPorId(int id)
        {
            return ctx.Agendamentos.FirstOrDefault(a => a.IdAgendamento == id);
        }

        public void CadastrarAgendamento(Agendamento novoAgendamento)
        {
            ctx.Agendamentos.Add(novoAgendamento);

            ctx.SaveChanges();
        }

        public void DeletarAgendamento(int id)
        {
            Agendamento agendamentoBuscado = ctx.Agendamentos.Find(id);

            ctx.Agendamentos.Remove(agendamentoBuscado);

            ctx.SaveChanges();
        }

        public List<Agendamento> ListarAgendamentos()
        {
            return ctx.Agendamentos.ToList();
        }
    }
}
