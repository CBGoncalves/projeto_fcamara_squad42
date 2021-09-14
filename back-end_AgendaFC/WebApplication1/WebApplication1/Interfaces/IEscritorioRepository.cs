using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface IEscritorioRepository
    {
        List<Escritorio> ListarEscritorios();

        void CadastrarEscritorio(Escritorio novoEscritorio);

        void DeletarEscritorio(int id);

        void AtualizarEscritorioPorId(int id, Escritorio escritorioAtualizado);
    }
}
