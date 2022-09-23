using Core.Seguridades.DataAccess.Aplicativos;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos
{
    public static class ObtenerListaAplicativosBLL
    {
        public static void ObtenerListaAplicativo(AplicativosTrx objetoTransaccional)
        {
            ObtenerListaAplicativoDAL.Execute(objetoTransaccional);
        }
    }
}
