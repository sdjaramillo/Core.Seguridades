using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.Configuracion
{
    public class VariableSistema
    {
        public VariableSistema() { }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Valor { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public string Grupo { get; set; }
    }
}
