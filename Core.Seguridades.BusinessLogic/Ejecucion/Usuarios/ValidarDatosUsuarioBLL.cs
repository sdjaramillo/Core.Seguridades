﻿using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    /// <summary>
    /// Realiza validaciones para los usuarios
    /// </summary>
    public static class ValidarDatosUsuarioBLL
    {
        /// <summary>
        /// Valida que cualquiera de los 6 campos de los usuarios no sean null
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void ValidarParametrosVacios (UsuarioTrx objetoTransaccional)
        {
            List<UsuarioActiveDirectory> usuariosInvalidos = new List<UsuarioActiveDirectory>();
            foreach (var usuario in objetoTransaccional.ListaUsuariosNuevos)
            {
                if (usuario.NombreEmpresa == null ||
                    usuario.ApellidoUsuario == null ||
                    usuario.CadenaNombreEmpresa == null ||
                    usuario.NombreEmpresa == null ||
                    usuario.CorreoElectronicoUsuario == null )
                {
                    usuariosInvalidos.Add(usuario);
                }
            }
            objetoTransaccional.ListaUsuariosNuevos = objetoTransaccional.ListaUsuariosNuevos.Except(usuariosInvalidos).ToList();
        }
    }
}
