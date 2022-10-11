using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.CredencialesAccesos
{
    /// <summary>
    /// Clase request para la actualizar Credencial Acceso
    /// </summary>
    public class ActualizarCredencialAccesoRequest
    {
        public int CredencialId { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Categoria { get; set; }
        public string EntidadId { get; set; }
    }
}
