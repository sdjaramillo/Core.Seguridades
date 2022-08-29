using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;


namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    /// <summary>
    /// Lógica de ejecución para obtener a los usuarios de active directory que no esta almacenado en la BD
    /// </summary>
    public static class ObtenerDatosUsuarioBLL
    {
        /// <summary>
        /// Método de sincronización entre usuarios de active directory con los de la BD
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void SicronizacionUsuariosActiveDirectoryBaseDatos(UsuarioTrx objetoTransaccional)
        {
            List<string> listaUsuariosActiveDirectory = objetoTransaccional.ListaUsuariosActiveDirectory
                .Select(x => x.NombreRedUsuario).ToList();
            List<string> listaUsuariosDB = objetoTransaccional.ListaUsuarios
                .Select(x => x.NombreRedUsuario).ToList();

            var usuariosNuevos = listaUsuariosActiveDirectory.Except(listaUsuariosDB).ToList();
            objetoTransaccional.ListaUsuariosNuevos = objetoTransaccional.ListaUsuariosActiveDirectory.Where(x => usuariosNuevos.Contains(x.NombreRedUsuario)).ToList();

            var usuariosEliminados = listaUsuariosDB.Except(listaUsuariosActiveDirectory).ToList();

            objetoTransaccional.CantidadUsuariosNuevos = usuariosNuevos.Count;
            objetoTransaccional.CantidadUsuariosEliminados = usuariosEliminados.Count;
        }

    }
}
