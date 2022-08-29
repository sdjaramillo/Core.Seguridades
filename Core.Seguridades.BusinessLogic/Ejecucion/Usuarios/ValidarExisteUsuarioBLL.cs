using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    public static class ValidarExisteUsuarioBLL
    {
        public static void ExistenciaUsuarioBaseDatos(UsuarioTrx objetoTransaccional)
        {
            List<Usuario> listaUsuariosBaseDatos = objetoTransaccional.ListaUsuarios.ToList();
            if (listaUsuariosBaseDatos.Count > 0)
            {
                var usuarioActualizar = listaUsuariosBaseDatos.Single(x => x.NombreRedUsuario == objetoTransaccional.UsuarioRequest.NombreRedUsuario);
                objetoTransaccional.Usuario = usuarioActualizar;
            }
            else {
                objetoTransaccional.Resultado.CodigoInternoRespuesta = (int)ErrorUsuario.NoExisteUsuariosBaseDatos;
            }
        }
    }
}
