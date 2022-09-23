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
    public class ObtenerListaAplicativosIN : IObtenerTodos<AplicativosTrx, ObtenerListaAplicativosResponse>
    {
        public void AgregarInformacion(AplicativosTrx objetoTransaccional)
        {
            ObtenerListaAplicativosBLL.ObtenerListaAplicativo(objetoTransaccional);
        }

        public void ValidarInformacion(AplicativosTrx objetoTransaccional)
        {
            
        }
    }
}
