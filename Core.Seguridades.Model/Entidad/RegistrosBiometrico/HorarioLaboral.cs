using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.RegistrosBiometrico
{
    public class HorarioLaboral
    {
        public HorarioLaboral () { }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public TimeSpan TiempoAlmuerzo { get; set; }
        public bool Estado { get; set; }
        public bool TiempoAtraso { get; set; }
    }
}
