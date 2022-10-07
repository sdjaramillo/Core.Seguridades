using Core.Seguridades.Model.Entidad.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Permisos
{
    public class EliminarPermisoResponse
    {
        public EliminarPermisoResponse()
        {
            EliminarPermiso = new Permiso();
        }
        public Permiso EliminarPermiso { get; set; }
    }
}
