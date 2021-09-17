using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class TurnoRepository : ITurnoRepository
    {

        AgendaFCContext ctx = new AgendaFCContext();

        public void AtualizarTurnoPorId(int id, Turno turnoAtualizado)
        {
            Turno turnoBuscado = ctx.Turnos.Find(id);

            turnoBuscado.TituloTurno = turnoAtualizado.TituloTurno;

            ctx.Turnos.Update(turnoBuscado);

            ctx.SaveChanges();
        }

        public void CadastrarTurno(Turno novoTurno)
        {
            ctx.Turnos.Add(novoTurno);

            ctx.SaveChanges();
        }

        public void DeletarTurno(int id)
        {
            Turno turnoBuscado = ctx.Turnos.Find(id);

            ctx.Turnos.Remove(turnoBuscado);

            ctx.SaveChanges();
        }

        public List<Turno> ListarTurnos()
        {
            return ctx.Turnos.ToList();
        }
    }
}
