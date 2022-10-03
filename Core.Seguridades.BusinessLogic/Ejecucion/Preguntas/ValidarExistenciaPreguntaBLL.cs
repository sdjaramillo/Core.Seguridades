using Core.Seguridades.Model.Entidad.Preguntas;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Preguntas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Preguntas
{
    public static class ValidarExistenciaPreguntaBLL
    {
        public static void ExistenciaPreguntaBaseDatos(PreguntaTrx objetoTransaccional)
        {
            List<Pregunta> ListaPreguntasBaseDatos = objetoTransaccional.ListadoPreguntas;
            if (ListaPreguntasBaseDatos.Count > 0)
            {
                try
                {
                    var preguntaVerificada = ListaPreguntasBaseDatos.Single(x => x.Codigo.ToString() == objetoTransaccional.PreguntaRequest.Codigo.ToString());
                    objetoTransaccional.PreguntaValida = preguntaVerificada;
                }catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                    objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorPregunta.NoExistePreguntaBaseDatos;
                }
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorPregunta.NoExistePreguntaBaseDatos;
            }
        }
    }
}
