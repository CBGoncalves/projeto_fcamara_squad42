using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Domains
{
    public partial class Turno
    {
        public Turno()
        {
            Agendamentos = new HashSet<Agendamento>();
        }

        public int IdTurno { get; set; }
        public string TituloTurno { get; set; }

        public virtual ICollection<Agendamento> Agendamentos { get; set; }
    }
}
