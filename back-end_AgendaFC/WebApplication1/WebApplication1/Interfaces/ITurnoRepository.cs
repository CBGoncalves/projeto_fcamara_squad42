using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface ITurnoRepository
    {
        List<Turno> ListarTurnos();

        void CadastrarTurno(Turno novoTurno);

        void DeletarTurno(int id);

        void AtualizarTurnoPorId(int id, Turno turnoAtualizado);
    }
}
