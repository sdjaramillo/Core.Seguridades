﻿using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.RegistrosBiometrico;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.Transaccion.Request.Usuarios;

namespace Core.Seguridades.Model.Transaccion.Transaccional.Usuarios
{
    /// <summary>
    /// Objeto transaccional de usuarios
    /// </summary>
    public class UsuarioTrx : TransaccionBase
    {
        /// <summary>
        /// Constructor del objeto transaccional donde se instancia las listas de usuarios
        /// </summary>
        public UsuarioTrx() {
            ListaUsuarios = new List<Usuario>();
            ListaUsuariosActiveDirectory = new List<UsuarioActiveDirectory>();
            ListaUsuariosNuevos = new List<UsuarioActiveDirectory>();
            ListaUsuariosEliminados = new List<string>();
            Usuario = new Usuario();
            ActualizarUsuarioRequest = new ActualizarUsuarioRequest();
            ListaCumpleanieros = new List<CumpleanieroMes>();
            RolAdministrador = new ObtenerUsuarioAdministradorRequest();
            AdministradorUsuario = new List<Administrador>();
            ListaCumpleanierosDia = new List<CumpleanieroMes>();
            HorarioLaboralUsuario = new List<HorarioLaboral>();
        }

        /// <summary>
        /// Usuario de la BD
        /// </summary>
        public Usuario Usuario { get; set; }

        /// <summary>
        /// Lista de usaurios de la BD
        /// </summary>
        public List<Usuario> ListaUsuarios { get; set; }

        /// <summary>
        /// Lista de usuarios nuevos entre active directory y la BD
        /// </summary>
        public List<UsuarioActiveDirectory> ListaUsuariosNuevos { get; set; }

        /// <summary>
        /// Lista de usuarios de Active Directory
        /// </summary>
        public List<UsuarioActiveDirectory> ListaUsuariosActiveDirectory { get; set; }

        /// <summary>
        /// Total numérico de usuarios nuevos
        /// </summary>
        public int CantidadUsuariosNuevos { get; set; }

        /// <summary>
        /// Total numéricos de usuarios eliminados
        /// </summary>
        public int CantidadUsuariosEliminados { get; set; }
        public List<string> ListaUsuariosEliminados { get; set; }

        /// <summary>
        /// Campos de usuario utilizado para actualizar la infromación
        /// </summary>
        public ActualizarUsuarioRequest ActualizarUsuarioRequest { get; set; }
        public string NombreRed { get; set; }
        public List<Administrador> AdministradorUsuario { get; set; }
        public List<CumpleanieroMes> ListaCumpleanieros { get; set; }
        public List<CumpleanieroMes> ListaCumpleanierosDia { get; set; }
        public ObtenerUsuarioAdministradorRequest RolAdministrador { get; set; }
        public List<HorarioLaboral> HorarioLaboralUsuario { get; set; }
    }
}
