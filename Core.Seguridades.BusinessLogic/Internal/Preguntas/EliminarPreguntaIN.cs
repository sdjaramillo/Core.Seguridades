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
    public class EliminarPreguntaIN : IEliminar<PreguntaTrx, EliminarPreguntaResponse>
    {
        public void AgregarInformacion(PreguntaTrx objetoTransaccional)
        {
            ObtenerListaPreguntaBLL.ObtenerListaPregunta(objetoTransaccional);
        }

        public void Eliminarnformacion(PreguntaTrx objetoTransaccional)
        {
            EliminarPreguntaBLL.EliminarPregunta(objetoTransaccional);
            ObtenerListaPreguntaBLL.ObtenerListaPregunta(objetoTransaccional);
        }

        public void ValidarInformacion(PreguntaTrx objetoTransaccional)
        {
            ValidarExistenciaPreguntaBLL.ExistenciaPreguntaBaseDatos(objetoTransaccional);
        }
    }
}
