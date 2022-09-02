using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.General
{
    public static class ConstantesRest 
    {
        public const string GUID_EMPTY = "00000000-0000-0000-0000-000000000000";
    }

    /// <summary>
    /// Parametos para obtener la lista de usuarios mediante el procedimiento almacenado
    /// </summary>
    public static class PA_SEG_OBTENER_LISTA_USUARIOS
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_LISTA_USUARIOS";
    }

    /// <summary>
    /// Parametos para agregar la lista de usuarios mediante el procedimiento almacenado
    /// </summary>
    public static class PA_SEG_AGREGAR_LISTA_USUARIOS
    {
        public const string NombreStoreProcedure = "PA_SEG_AGREGAR_LISTA_USUARIOS";
        public const string NombreRedUsuario = "@NombreRedUsuario";
        public const string NombresUsuario = "@NombreUsuario";
        public const string ApellidosUsuario = "@ApellidoUsuario";
        public const string NombreEmpresa = "@NombreEmpresa";
        public const string FechaIngresoUsuario = "@FechaIngresoUsuario";
        public const string CorreoElectronicoUsuario = "@CorreoElectronicoUsuario";
        public const string CiudadUsuario = "@CiudadUsuario";
        public const string Retorno = "@RESULT";
    }

    /// <summary>
    /// Parametos para migrar la lista de usaurios almacenados en active directory
    /// </summary>
    public static class MigrarUsuariosActiveDirectoryConstantes
    {
        public const string IdentificarEmpresa = "-";
        public const string NombreUsuario = "givenName";
        public const string ApellidoUsuario = "sn";
        public const string CadenaNombreEmpresa = "description";
        public const string FechaIngresoUsuario = "whenCreated";
        public const string NombreRedUsuario = "sAMAccountName";
        public const string CorreoElectronicoUsuario = "userPrincipalName";
    }

    /// <summary>
    /// Parametros para actualizar un usuario almacenado en la base de datos
    /// </summary>
    public static class PA_SEG_ACTUALIZAR_USUARIO
    {
        public const string NombreStoreProcedure = "PA_SEG_ACTUALIZAR_USUARIO";
        public const string CodigoHorarioLaboral = "@HorarioLaboralCodigo";
        public const string CodigoRol = "@RolCodigo";
        public const string CodigoEmpresa = "@EmpresaCodigo";
        public const string NombreRedUsuario = "@NombreRedUsuario";
        public const string NombreUsuario = "@NombreUsuario";
        public const string ApellidoUsuario = "@ApellidoUsuario";
        public const string FechaNacimientoUsuario = "@FechaNacimientoUsuario";
        public const string FechaIngresoUsuario = "@FechaIngresoUsuario";
        public const string FechaSalidaUsuario = "@FechaSalidaUsuario";
        public const string EstadoUsuario = "@EstadoUsuario";
        public const string CorreoElectronicoUsuario = "@CorreoElectronicoUsuario";
        public const string DescripcionUsuario = "@DescripcionUsuario";
        public const string ImagenUsuario = "@ImagenUsuario";
    }

    /// <summary>
    /// Parametros para eliminación logica de un usuario almacenado en la base de datos
    /// </summary>
    public static class PA_SEG_ELIMINAR_USUARIO
    {
        public const string NombreStoreProcedure = "PA_SEG_ELIMINAR_USUARIO";
        public const string NombreRedUsuario = "@NombreRedUsuario";
    }
}
