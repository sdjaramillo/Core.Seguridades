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
        public int VariableSistemaId { get; set; }
        public string CodigoVariableSistema { get; set; }
        public string NombreVariableSistema { get; set; }
        public string ValorVariableSistema { get; set; }
        public string DescripcionVariableSistema { get; set; }
        public bool EstadoVariableSistema { get; set; }
        public string GrupoVariableSistema { get; set; }
    }
}
