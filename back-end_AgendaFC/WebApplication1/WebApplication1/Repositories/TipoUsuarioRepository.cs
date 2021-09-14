using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Contexts;
using WebApplication1.Domains;
using WebApplication1.Interfaces;

namespace WebApplication1.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        AgendaFCContext ctx = new AgendaFCContext();

        public List<TipoUsuario> ListarTiposUsuario()
        {
            return ctx.TipoUsuarios.ToList();
        }
    }
}
