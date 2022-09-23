using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Noticias;
using Core.Seguridades.Model.Transaccion.Response.Noticias;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Internal.Noticias
{
    public class EliminarNoticiaIN: IEliminar<NoticiaTrx, EliminarNoticiaResponse>
    {
        public void AgregarInformacion(NoticiaTrx objetoTransaccional)
        {
            ObtenerListaNoticiaBLL.ObtenerListaNoticia(objetoTransaccional);
        }

        public void ValidarInformacion(NoticiaTrx objetoTransaccional)
        {
            ValidarExistenciaNoticiaBLL.ExistenciaNoticiaBaseDatos(objetoTransaccional);
        }

        public void Eliminarnformacion(NoticiaTrx objetoTransaccional)
        {
            EliminarNoticaBLL.EliminarNoticia(objetoTransaccional);
        }
    }
}
