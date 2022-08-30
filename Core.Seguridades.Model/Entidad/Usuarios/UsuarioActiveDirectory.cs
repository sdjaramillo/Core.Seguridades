using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Entidad.Usuarios
{
    /// <summary>
    /// Modelo de los datos necesarios obtenidos desde active directory
    /// </summary>
    public class UsuarioActiveDirectory
    {
        public UsuarioActiveDirectory() { }

        public string NombreUsuario { get; set; } 
        public string ApellidoUsuario { get; set; } 
        public string CadenaNombreEmpresa { get; set; } 
        public string NombreEmpresa { get; set; } 
        public DateTime FechaIngresoUsuario { get; set; } 
        public string NombreRedUsuario { get; set; } 
        public string CorreoElectronicoUsuario { get; set; } 

        public string CiudadUsuario { get; set; } 
    }
}
