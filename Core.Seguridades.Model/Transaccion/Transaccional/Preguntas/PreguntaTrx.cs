using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.Preguntas;
using Core.Seguridades.Model.Transaccion.Request.Preguntas;
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
            CodigoPregunta = "";
            PreguntaRequest = new PreguntaRequest();
            PreguntaValida = new Pregunta();
        }
        public List<Pregunta> ListadoPreguntas { get; set; }
        public string NombreRedRequest { get; set; }
        public PreguntaRequest PreguntaRequest { get; set; }
        public Pregunta PreguntaValida { get; set; }
        public string CodigoPregunta { get; set; }
    }
}
