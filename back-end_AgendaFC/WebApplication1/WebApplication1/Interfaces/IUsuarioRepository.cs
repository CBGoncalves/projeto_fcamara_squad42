using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> ListarUsuarios();

        void CadastrarUsuario(Usuario novoUsuario);

        void DeletarUsuario(int id);

        Usuario BuscarUsuarioPorId(int id);

        void AtualizarUsuarioPorId(int id, Usuario usuarioAtualizado);
    }
}
