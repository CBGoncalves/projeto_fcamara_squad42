using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface ITipoAgendamentoRepository
    {
        List<TipoAgendamento> ListarTiposAgendamento();

        void CadastrarTipoAgendamento(TipoAgendamento novoTipoAgendamento);

        void DeletarTipoAgendamento(int id);

        void AtualizarTipoAgendamentoPorId(int id, TipoAgendamento tipoAgendamentoAtualizado);

    }
}
