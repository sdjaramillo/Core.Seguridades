using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.CredencialesAccesos
{
    public class CredencialAcceso
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public string Cat_id_tipo { get; set; }
        public string EntidadId { get; set; }
    }
}
