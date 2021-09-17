using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Domains
{
    public partial class TipoAgendamento
    {
        public TipoAgendamento()
        {
            Agendamentos = new HashSet<Agendamento>();
        }

        public int IdTipoAgendamento { get; set; }
        public string TituloTipoAgendamento { get; set; }

        public virtual ICollection<Agendamento> Agendamentos { get; set; }
    }
}
