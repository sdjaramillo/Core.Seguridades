using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.Preguntas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Transaccional.Preguntas
{
    public class PreguntaTrx : TransaccionBase
    {
        public PreguntaTrx()
        {
            ListadoPreguntas = new List<Pregunta>();
            NombreRedRequest = "";
        }
        public List<Pregunta> ListadoPreguntas { get; set; }
        public string NombreRedRequest;
    }
}
