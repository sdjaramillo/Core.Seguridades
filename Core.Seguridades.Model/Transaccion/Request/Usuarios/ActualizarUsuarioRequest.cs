using Core.Seguridades.Model.Entidad.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Request.Usuarios
{
    /// <summary>
    /// Solicitud de datos para actualizar usaurio
    /// </summary>
    public class ActualizarUsuarioRequest
    {
        public ActualizarUsuarioRequest() 
        {
        
        }
        public string CodigoHorarioLaboral { get; set; }
        public string CodigoRol { get; set; }
        public string CodigoEmpresa { get; set; }
        public string NombreRedUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public DateTime FechaNacimientoUsuario { get; set; }
        public DateTime FechaIngresoUsuario { get; set; }
        public DateTime? FechaSalidaUsuario { get; set; }
        public byte[] ImagenUsuario { get; set; }
        public string CorreoElectronicoUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
        public string DescripcionUsuario { get; set; }
    }
}
