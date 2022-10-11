using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Usuarios
{
    /// <summary>
    /// Respuesta al migrar la lista de usarios de active directory a la BD
    /// </summary>
    public class MigrarUsuariosActiveDirectoryResponse
    {
        public int CantidadUsuariosNuevos { get; set; }
        public int CantidadUsuariosEliminados { get; set; }
    }
}
