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
        public TimeSpan HoraEntrada { get; set; }
        public TimeSpan HoraSalida { get; set; }
        public bool Estado { get; set; }

    }
}
