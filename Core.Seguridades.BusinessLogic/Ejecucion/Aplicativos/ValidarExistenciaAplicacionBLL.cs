using Core.Seguridades.Model.Entidad.Aplicativos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos
{
    public static class ValidarExistenciaAplicacionBLL
    {
        public static void ExistenciaAplicativoBaseDatos(AplicativosTrx objetoTransaccional)
        {
            List<Aplicativo> ListaAplicativoBaseDatos = objetoTransaccional.ListadoAplicativos.ToList();
            if(ListaAplicativoBaseDatos.Count > 0)
            {
                var aplicativoVerificado = ListaAplicativoBaseDatos.Single(x => x.Codigo.ToString() == objetoTransaccional.AplicativoCodigo.ToString());
                objetoTransaccional.AplicativoValido = aplicativoVerificado;
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.NoExisteAplicativoBaseDatos;
            }
        }
    }
}
