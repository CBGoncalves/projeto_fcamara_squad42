using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Domains
{
    public partial class Agendamento
    {
        public int IdAgendamento { get; set; }
        public DateTime DataAgendamento { get; set; }
        public int IdUsuario { get; set; }
        public int IdTipoAgendamento { get; set; }
        public int IdEscritorio { get; set; }
        public int IdTurno { get; set; }

        public virtual Escritorio IdEscritorioNavigation { get; set; }
        public virtual TipoAgendamento IdTipoAgendamentoNavigation { get; set; }
        public virtual Turno IdTurnoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
