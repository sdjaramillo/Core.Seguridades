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
        public const string TIEMPO_ATRASO_EMPLEADO = "VAS_003";
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

    public static class PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO
    {
        public const string NombreStoreProcedure = "PA_INT_AGREGAR_LISTA_REGISTRO_BIOMETRICO";
        public const string NombreRed = "@NombreRed";
        public const string Codigo = "@Codigo";
        public const string FechaRegistro = "@FechaRegistro";
        public const string HoraEntrada = "@HoraEntrada";
        public const string IpRegistro = "@IpRegistro";
        public const string PcNombre = "@PcNombre";
        public const string Retorno = "@CodigoRetorno"; 
        public const string Atraso = "@Atraso"; 
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

    public static class ConstantesInicialesEmpresas
    {
        public static readonly string[] InicalesEmpresas = { "ORI", "INT", "REC" };
    }

    public static class PA_INT_OBTENER_LISTA_IMAGENES
    {
        public static string NombreStoreProcedure = "PA_INT_OBTENER_LISTA_IMAGENES";
        public static string NombreRed = "@NombreRed";
        public static string Tipo = "@Tipo";
    }

    public static class PA_SEG_OBTENER_USUARIO
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_USUARIO";
        public const string NombreRed = "@NombreRed";
    }

    public static class PA_INT_OBTENER_LISTA_REGISTRO_BIOMETRICO
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_LISTA_REGISTRO_BIOMETRICO";
        public const string NombreRed = "@NombreRed";
    }

    public static class PA_SEG_OBTENER_HORA_ENTRADA
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_HORA_ENTRADA";
        public const string NombreRed = "@NombreRed";
    }
    public static class PA_INT_OBTENER_TOTAL_ATRASOS_MES
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_TOTAL_ATRASOS_MES";
        public const string NombreRed = "@NombreRed";
    }
    public static class PA_SEG_OBTENER_LISTA_CUMPLEANIERO_MES
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_LISTA_CUMPLEANIERO_MES";
    }
    public static class PA_SEG_OBTENER_LOGO_EMPRESA
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_LOGO_EMPRESA";
        public const string NombreRed = "@NombreRed";
    }

    public static class PA_SEG_OBTENER_PERMISO_ADMINISTRADOR
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_PERMISO_ADMINISTRADOR";
        public const string NombreRed = "@NombreRed";
        public const string ProyectoCodigo = "@ProyectoCodigo";
    }
    public static class PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO
    {
        public const string NombreStoreProcedure = "PA_INT_ACTUALIZAR_REGISTRO_BIOMETRICO";
        public const string EstadoAnimoCodigo = "@EstadoAnimoCodigo";
        public const string NombreRed = "@NombreRed"; 
        public const string Codigo = "@Codigo";
        public const string FechaRegistro = "@FechaRegistro";
        public const string HoraEntrada = "@HoraEntrada";
        public const string HoraSalida = "@HoraSalida";
        public const string IpRegistro = "@IpRegistro";
        public const string PcNombre = "@PcNombre";
        public const string HoraInicioAlmuerzo = "@HoraInicioAlmuerzo";
        public const string HoraFinAlmuerzo = "@HoraFinAlmuerzo";
        public const string TiempoAtraso = "@TiempoAtraso";
        public const string Descripcion = "@Descripcion";
    }
}
