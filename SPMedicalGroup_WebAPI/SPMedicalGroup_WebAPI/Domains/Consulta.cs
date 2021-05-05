using System;
using System.Collections.Generic;

#nullable disable

namespace SPMedicalGroup_WebAPI.Domains
{
    public partial class Consulta
    {
        public int IdConsulta { get; set; }
        public int? IdMedico { get; set; }
        public int? IdPaciente { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Situacao { get; set; }

        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
    }
}
