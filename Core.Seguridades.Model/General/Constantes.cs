using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.General
{
    public static class ConstantesVariablesSistema
    {
        public const string IP_GENERAL_ACTIVE_DIRECTORY = "VAS_002";
    }
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
        public const string NombreRed = "@NombreRed";
        public const string Nombres = "@Nombres";
        public const string Apellidos = "@Apellidos";
        public const string NombreEmpresa = "@NombreEmpresa";
        public const string FechaIngreso = "@FechaIngreso";
        public const string CorreoElectronico = "@CorreoElectronico";
        public const string Ciudad = "@Ciudad";
        public const string Retorno = "@CodigoRetorno";
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
        public const string CodigoEmpresa = "@EmpresaCodigo";
        public const string NombreRed = "@NombreRed";
        public const string Nombres = "@Nombres";
        public const string Apellidos = "@Apellidos";
        public const string Ciudad = "@Ciudad";
        public const string FechaNacimiento = "@FechaNacimiento";
        public const string FechaIngreso = "@FechaIngreso";
        public const string FechaSalida = "@FechaSalida";
        public const string Estado = "@Estado";
        public const string CorreoElectronico = "@CorreoElectronico";
        public const string Descripcion = "@Descripcion";
        public const string Imagen = "@Imagen";
        public const string Retorno = "@RESULT";
    }

    /// <summary>
    /// Parametros para eliminación logica de un usuario almacenado en la base de datos
    /// </summary>
    public static class PA_SEG_ELIMINAR_USUARIO
    {
        public const string NombreStoreProcedure = "PA_SEG_ELIMINAR_USUARIO";
        public const string NombreRed = "@NombreRed";
    }

    public static class PA_SEG_OBTENER_MENU_ROL
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_MENU_ROL";
        public const string NombreRed = "@NombreRed";
        public const string ProyectoCodigo = "@ProyectoCodigo";
    }

    public static class CosntantesInicialesEmpresas
    {
        public static readonly string[] inicalesEmpresas = { "ORI", "INT", "REC" };
    }
}
