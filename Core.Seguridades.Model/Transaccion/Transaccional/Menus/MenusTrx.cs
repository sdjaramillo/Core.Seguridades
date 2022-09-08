using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.Configuracion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Transaccional.Configuracion
{
    public class MenusTrx : TransaccionBase
    {
        public MenusTrx() 
        {
            ListaVariableSistema = new List<VariableSistema>();
        }
        public List<VariableSistema> ListaVariableSistema { get; set; }
    }
}
