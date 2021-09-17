using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {

        AgendaFCContext ctx = new AgendaFCContext();

        public void AtualizarUsuarioPorId(int id, Usuario usuarioAtualizado)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);

            usuarioBuscado.NomeUsuario = usuarioAtualizado.NomeUsuario;

            usuarioBuscado.Email = usuarioAtualizado.Email;

            usuarioBuscado.Senha = usuarioAtualizado.Senha;

            ctx.Usuarios.Update(usuarioBuscado);

            ctx.SaveChanges();
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(u => u.IdUsuario == id);
        }

        public void CadastrarUsuario(Usuario novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);

            ctx.SaveChanges();
        }

        public void DeletarUsuario(int id)
        {
            Usuario usuarioBuscado = ctx.Usuarios.Find(id);

            ctx.Usuarios.Remove(usuarioBuscado);

            ctx.SaveChanges();
        }

        public List<Usuario> ListarUsuarios()
        {
            return ctx.Usuarios.ToList();
        }

        public Usuario Login(string email, string senha)
        {
                return ctx.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);   
        }
    }
}
