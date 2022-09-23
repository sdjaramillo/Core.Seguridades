using Core.Seguridades.DataAccess.Noticias;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Noticias
{
    public static class AgregarNoticiaBLL
    {
        public static void AgregarNoticia(NoticiaTrx objetoTransaccional)
        {
            AgregarNoticiaDAL.Execute(objetoTransaccional);
        }
    }
}
