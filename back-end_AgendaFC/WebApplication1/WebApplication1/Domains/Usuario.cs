using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Agendamentos = new HashSet<Agendamento>();
        }

        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int IdTipoUsuario { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Agendamento> Agendamentos { get; set; }
    }
}
