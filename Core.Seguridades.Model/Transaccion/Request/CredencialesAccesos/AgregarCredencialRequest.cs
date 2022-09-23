using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.CredencialesAccesos
{
    /// <summary>
    /// Clase con formato request para agregar una nueva credencial de acceso
    /// </summary>
    public class AgregarCredencialRequest
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Categoria { get; set; }
        public string Entidad { get; set; }
    }
}
