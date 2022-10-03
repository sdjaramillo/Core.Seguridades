using Core.Seguridades.Model.Entidad.Aplicativos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos
{
    public static class ValidarExistenciaAplicacionBLL
    {
        public static void ExistenciaAplicativoBaseDatos(AplicativosTrx objetoTransaccional)
        {
            List<Aplicativo> ListaAplicativoBaseDatos = objetoTransaccional.ListadoAplicativos.ToList();
            if(ListaAplicativoBaseDatos.Count > 0)
            {
                try
                {
                    var aplicativoVerificado = ListaAplicativoBaseDatos.Single(x => x.Codigo.ToString() == objetoTransaccional.AplicativoRequest.Codigo.ToString());
                    objetoTransaccional.AplicativoValido = aplicativoVerificado;
                }catch(Exception e)
                {
                    Console.WriteLine(e.ToString());
                    objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.NoExisteAplicativoBaseDatos;
                }
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.NoExisteAplicativoBaseDatos;
            }
        }
    }
}
