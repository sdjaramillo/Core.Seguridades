using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.RegistrosBiometrico
{
    public class AgregarRegistroBiometricoRequest
    {
        public AgregarRegistroBiometricoRequest() { }
        public string NombreRed { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string HoraEntrada { get; set; }
        public string IpRegistro { get; set; }
        public string PcNombre { get; set; }
    }
}
