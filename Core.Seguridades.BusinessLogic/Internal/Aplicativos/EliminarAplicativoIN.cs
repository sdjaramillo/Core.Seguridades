using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos;
using Core.Seguridades.Model.Transaccion.Response.Aplicativos;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Internal.Aplicativos
{
    public class EliminarAplicativoIN : IEliminar<AplicativosTrx, EliminarAplicativoResponse>
    {
        public void AgregarInformacion(AplicativosTrx objetoTransaccional)
        {
            ObtenerTodaAplicativosBLL.ObtenerListaAplicativos(objetoTransaccional);
        }

        public void Eliminarnformacion(AplicativosTrx objetoTransaccional)
        {
            EliminarAplicativoBLL.EliminarAplicativo(objetoTransaccional);
        }

        public void ValidarInformacion(AplicativosTrx objetoTransaccional)
        {
            ValidarExistenciaAplicacionBLL.ExistenciaAplicativoBaseDatos(objetoTransaccional);
        }
    }
}
