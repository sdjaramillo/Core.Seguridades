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

        public string NombreUsuario { get; set; } //givenName
        public string ApellidoUsuario { get; set; } //sn
        public string CadenaNombreEmpresa { get; set; } //distinguishedName
        public string NombreEmpresa { get; set; } 
        public DateTime FechaIngresoUsuario { get; set; } //whenCreated
        public string NombreRedUsuario { get; set; } //sAMAccountName
        public string CorreoElectronicoUsuario { get; set; } //mail
    }
}
