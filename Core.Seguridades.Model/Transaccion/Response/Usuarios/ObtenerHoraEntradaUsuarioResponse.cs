using Core.Seguridades.Model.Entidad.RegistrosBiometrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Usuarios
{
    public class ObtenerHoraEntradaUsuarioResponse
    {
        public ObtenerHoraEntradaUsuarioResponse()
        {
            HorarioUsuario = new List<HorarioLaboral>();
        }
        public List<HorarioLaboral> HorarioUsuario { get; set; }
    }
}
