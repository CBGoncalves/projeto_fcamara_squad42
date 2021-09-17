using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Domains
{
    public partial class Escritorio
    {
        public Escritorio()
        {
            Agendamentos = new HashSet<Agendamento>();
        }

        public int IdEscritorio { get; set; }
        public string TituloEscritorio { get; set; }
        public string EnderecoEscritorio { get; set; }

        public virtual ICollection<Agendamento> Agendamentos { get; set; }
    }
}
