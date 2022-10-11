using Core.Seguridades.Model.Entidad.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Usuarios
{
    public class ObtenerListaCumpleaniosResponse
    {
        public  ObtenerListaCumpleaniosResponse()
        {
            Cumpleanieros = new List<CumpleanieroMes>();
        }
        public List<CumpleanieroMes> Cumpleanieros { get; set; }
    }
}
