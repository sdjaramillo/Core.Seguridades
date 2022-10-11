using Core.Seguridades.DataAccess.Preguntas;
using Core.Seguridades.Model.Transaccion.Transaccional.Preguntas;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Preguntas
{
    public static class ObtenerListaPreguntaBLL
    {
        public static void ObtenerListaPregunta(PreguntaTrx objetoTransaccional)
        {
            ObtenerListaPreguntaDAL.Execute(objetoTransaccional);
        }
    }

}
