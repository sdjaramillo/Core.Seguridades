using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.Contactos
{
    public class Contacto
    {
        public Contacto() { }
        public int Id { get; set; }
        public string NombreRed { get; set; }
        public string Cargo { get; set; }
        public string CorreoElectronico { get; set; }
        public int Extension { get; set; }
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
    }
}
