using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Preguntas;
using Core.Seguridades.Model.Transaccion.Response.Preguntas;
using Core.Seguridades.Model.Transaccion.Transaccional.Preguntas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Internal.Preguntas
{
    public class ActualizarPreguntaIN : IActualizar<PreguntaTrx, ActualizarPreguntaResponse>
    {
        public void ActualizarInformacion(PreguntaTrx objetoTransaccional)
        {
            ActualizarPreguntaBLL.ActualizarPregunta(objetoTransaccional);
        }

        public void AgregarInformacion(PreguntaTrx objetoTransaccional)
        {
            ObtenerTodaPreguntaBLL.ObtenerListaPreguntas(objetoTransaccional);
        }

        public void HomologarInformacion(PreguntaTrx objetoTransaccional)
        {
            
        }

        public void ValidarInformacion(PreguntaTrx objetoTransaccional)
        {
            ValidarDatosPreguntaBLL.ValidarCamposVaciosPregunta(objetoTransaccional);
            ValidarExistenciaPreguntaBLL.ExistenciaPreguntaBaseDatos(objetoTransaccional);
        }
    }
}
