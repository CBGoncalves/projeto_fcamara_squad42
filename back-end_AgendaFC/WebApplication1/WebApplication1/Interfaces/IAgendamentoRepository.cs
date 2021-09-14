using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface IAgendamentoRepository
    {
        List<Agendamento> ListarAgendamentos();

        void CadastrarAgendamento(Agendamento novoAgendamento);

        void DeletarAgendamento(int id);

        Agendamento BuscarAgendamentoPorId(int id);

        void AtualizarAgendamentoPorId(int id, Agendamento agendamentoAtualizado);
    }
}
