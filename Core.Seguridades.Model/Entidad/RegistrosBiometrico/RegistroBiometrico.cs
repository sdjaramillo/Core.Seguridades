using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.RegistroBiometrico
{
    public class RegistroBiometrico
    {
        public RegistroBiometrico() { }
        public int IdRegistroBiometrico { get; set; }
        public string EstadoAnimoCodigo { get; set; }
        public string NombreRed { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public string IpRegistro { get; set; }
        public string PcNombre { get; set; }
        public TimeSpan HoraInicioAlmuerzo { get; set; }
        public TimeSpan HoraFinAlmuerzo { get; set; }
        public float TiempoAtraso { get; set; }
        public string Descripcion { get; set; }
    }
}
