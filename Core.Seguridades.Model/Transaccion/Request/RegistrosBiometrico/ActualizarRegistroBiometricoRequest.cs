using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.RegistrosBiometrico
{
    public class ActualizarRegistroBiometricoRequest
    {
        public ActualizarRegistroBiometricoRequest() {}
        public string EstadoAnimoCodigo { get; set; }
        public string NombreRed { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }
        public string IpRegistro { get; set; }
        public string PcNombre { get; set; }
        public string HoraInicioAlmuerzo { get; set; }
        public string HoraFinAlmuerzo { get; set; }
        public float TiempoAtraso { get; set; }
        public string Descripcion { get; set; }
    }

}
