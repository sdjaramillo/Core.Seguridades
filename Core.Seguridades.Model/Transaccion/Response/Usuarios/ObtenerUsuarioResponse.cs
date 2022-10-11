using Core.Seguridades.Model.Entidad.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Response.Usuarios
{
    public class ObtenerUsuarioResponse
    {
        public ObtenerUsuarioResponse()
        {
            UsuarioPerfil = new Usuario();
        }
        public Usuario UsuarioPerfil { get; set; }
    }
}
