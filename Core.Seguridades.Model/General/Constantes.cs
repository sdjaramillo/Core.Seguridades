﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.General
{
    public static class ConstantesVariablesSistema
    {
        public const string IP_GENERAL_ACTIVE_DIRECTORY = "VAS_002";
        public const string TIEMPO_ATRASO_EMPLEADO = "VAS_003";
        public const string TIEMPO_ALMUERZO = "VAS_004";
        public const string ORIGINARSA_CUMPLEANIERO_DIA = "VAS_005";
        public const string INTERBROQUER_CUMPLEANIERO_DIA = "VAS_006";
        public const string RECAUDA_CUMPLEANIERO_DIA = "VAS_007";
        public const string ALMUERZO_TARDE = "VAS_008";
        public const string HORA_VACIA = "VAS_009";

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
        public const string Atraso = "@Atraso";

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

        public const string Retorno = "@CodigoRetorno";
    }

    /// <summary>
    /// Parametros para actualizar un usuario almacenado en la base de datos
    /// </summary>
    public static class PA_SEG_ACTUALIZAR_USUARIO
    {
        
        public const string NombreStoreProcedure = "PA_SEG_ACTUALIZAR_USUARIO";
        public const string Id = "@Id";
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

        public const string Retorno = "@CodigoRetorno";
    }


    /// <summary>
    /// Parametros para eliminación logica de un usuario almacenado en la base de datos
    /// </summary>
    public static class PA_SEG_ELIMINAR_USUARIO
    {
        public const string NombreStoreProcedure = "PA_SEG_ELIMINAR_USUARIO";
        public const string NombreRed = "@NombreRed";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_SEG_OBTENER_MENU_ROL
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_MENU_ROL";
        public const string NombreRed = "@NombreRed";
        public const string ProyectoCodigo = "@ProyectoCodigo";
    }

    public static class PA_SEG_OBTENER_PERMISOS_MENU
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_PERMISOS_MENU";
    }

    public static class ConstantesInicialesEmpresas
    {
        public static readonly string[] InicalesEmpresas = { "ORI", "INT", "REC" };
        public static readonly string[] CodigoEmpresas = { "EMP_001", "EMP_002", "EMP_003" };
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
        public const string NombreRed = "@NombreRed";
    }
    public static class PA_SEG_OBTENER_CUMPLEANIEROS_DIA
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_CUMPLEANIEROS_DIA";
        public const string NombreRed = "@NombreRed";
        public const string EmpresaCodigo = "@EmpresaCodigo";
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

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_OBTENER_LISTA_NOTICIAS
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_LISTA_NOTICIAS";
        public const string NombreRed = "@NombreRed";
    }

    public static class PA_INT_OBTENER_LISTA_PREGUNTAS
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_LISTA_PREGUNTAS";
        public const string NombreRed = "@NombreRed";
    }

    public static class PA_INT_OBTENER_LISTA_TODOS_NOTICIAS
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_LISTA_TODOS_NOTICIAS";
    }

    public static class PA_INT_OBTENER_LISTA_TODOS_PREGUNTAS
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_LISTA_TODOS_PREGUNTAS";
    }

    public static class PA_INT_AGREGAR_IMAGEN
    {
        public const string NombreStoreProcedure = "PA_INT_AGREGAR_IMAGEN";
        public const string Codigo = "@Codigo";
        public const string EmpresaCodigo = "@EmpresaCodigo";
        public const string Nombre = "@Nombre";
        public const string Tipo = "@Tipo";
        public const string Valor = "@Valor";
        public const string FechaCreacion = "@FechaCreacion";
        public const string FechaCaducidad = "@FechaCaducidad";
        public const string Descripcion = "@Descripcion";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_ACTUALIZAR_IMAGEN
    {
        public const string NombreStoreProcedure = "PA_INT_ACTUALIZAR_IMAGEN";
        public const string Codigo = "@Codigo";
        public const string EmpresaCodigo = "@EmpresaCodigo";
        public const string Nombre = "@Nombre";
        public const string Tipo = "@Tipo";
        public const string Valor = "@Valor";
        public const string Estado = "@Estado";
        public const string FechaCreacion = "@FechaCreacion";
        public const string FechaCaducidad = "@FechaCaducidad";
        public const string Descripcion = "@Descripcion";

        public const string Retorno = "@CodigoRetorno";
    }
    public static class PA_INT_ELIMINAR_IMAGEN
    {
        public const string NombreStoreProcedure = "PA_INT_ELIMINAR_IMAGEN";
        public const string ImagenCodigo = "@ImagenCodigo";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_OBTENER_TODAS_IMAGENES
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_TODAS_IMAGENES";
        public const string Id = "@Id";
        public const string Codigo = "@Codigo";
        public const string EmpresaCodigo = "@EmpresaCodigo";
        public const string Nombre = "@Nombre";
        public const string Tipo = "@Tipo";
        public const string Valor = "@Valor";
        public const string Estado = "@Estado";
        public const string FechaCreacion = "@FechaCreacion";
        public const string FechaCaducidad = "@FechaCaducidad";
        public const string Descripcion = "@Descripcion";
    }

    public static class PA_INT_ACTUALIZAR_NOTICIA
    {
        public const string NombreStoreProcedure = "PA_INT_ACTUALIZAR_NOTICIA";
        public const string CodigoNoticia = "@CodigoNoticia";
        public const string CodigoPermisoPublicacion = "@CodigoPermisoPublicacion";
        public const string Titulo = "@Titulo";
        public const string Imagen = "@Imagen";
        public const string Descripcion = "@Descripcion";
        public const string Publico = "@Publico";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_ACTUALIZAR_PREGUNTA
    {
        public const string NombreStoreProcedure = "PA_INT_ACTUALIZAR_PREGUNTA";
        public const string CodigoPregunta = "@CodigoPregunta";
        public const string CodigoPermisoPublicacion = "@CodigoPermisoPublicacion";
        public const string Titulo = "@Titulo";
        public const string Imagen = "@Imagen";
        public const string Descripcion = "@Descripcion";
        public const string Publico = "@Publico";
        public const string Estado = "@Estado";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_AGREGAR_NOTICIA
    {
        public const string NombreStoreProcedure = "PA_INT_AGREGAR_NOTICIA";
        public const string CodigoPermisoPublicacion = "@CodigoPermisoPublicacion";
        public const string Codigo = "@Codigo";
        public const string Titulo = "@Titulo";
        public const string Imagen = "@Imagen";
        public const string Descripcion = "@Descripcion";
        public const string Publico = "@Publico";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_AGREGAR_PREGUNTA
    {
        public const string NombreStoreProcedure = "PA_INT_AGREGAR_PREGUNTA";
        public const string CodigoPermisoPublicacion = "@CodigoPermisoPublicacion";
        public const string Codigo = "@Codigo";
        public const string Titulo = "@Titulo";
        public const string Imagen = "@Imagen";
        public const string Descripcion = "@Descripcion";
        public const string Publico = "@Publico";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_ELIMINAR_NOTICIA
    {
        public const string NombreStoreProcedure = "PA_INT_ELIMINAR_NOTICIA";
        public const string CodigoNoticia = "@CodigoNoticia";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_ELIMINAR_PREGUNTA
    {
        public const string NombreStoreProcedure = "PA_INT_ELIMINAR_PREGUNTA";
        public const string CodigoPregunta = "@CodigoPregunta";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_OBTENER_REGISTRO_DIA
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_REGISTRO_DIA";
        public const string NombreRed = "@NombreRed";
    }

    public static class PA_INT_AGREGAR_APLICATIVO
    {
        public const string NombreStoreProcedure = "PA_INT_AGREGAR_APLICATIVO";
        public const string Codigo = "@Codigo";
        public const string Nombre = "@Nombre";
        public const string Logo = "@Logo";
        public const string Estado = "@Estado";
        public const string Ruta = "@Ruta";
        public const string Descripcion = "@Descripcion";

        public const string Retorno = "@CodigoRetorno";
    }
    public static class PA_SEG_AGREGAR_PERMISOS
    {
        public const string NombreStoreProcedure = "PA_SEG_AGREGAR_PERMISOS";
        public const string Codigo = "@Codigo";
        public const string NombreRed = "@NombreRed";
        public const string RolCodigo = "@RolCodigo";
        public const string ProyectoCodigo = "@ProyectoCodigo";
        public const string Nombre = "@Nombre";
        public const string Descripcion = "@Descripcion";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_SEG_AGREGAR_PERMISO_MENU
    {
        public const string NombreStoreProcedure = "PA_SEG_AGREGAR_PERMISO_MENU";
        public const string MenuCodigo = "@MenuCodigo";
        public const string RolCodigo = "@RolCodigo";
        public const string OpcionMenuCodigo = "@OpcionMenuCodigo";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_ACTUALIZAR_APLICATIVO
    {
        public const string NombreStoreProcedure = "PA_INT_ACTUALIZAR_APLICATIVO";
        public const string Codigo = "@Codigo";
        public const string Nombre = "@Nombre";
        public const string Logo = "@Logo";
        public const string Estado = "@Estado";
        public const string Ruta = "@Ruta";
        public const string Descripcion = "@Descripcion";

        public const string Retorno = "@CodigoRetorno";
    }
    public static class PA_SEG_ACTUALIZAR_PERMISOS
    {
        public const string NombreStoreProcedure = "PA_SEG_ACTUALIZAR_PERMISOS";
        public const string Codigo = "@Codigo";
        public const string NombreRed = "@NombreRed";
        public const string RolCodigo = "@RolCodigo";
        public const string ProyectoCodigo = "@ProyectoCodigo";
        public const string Nombre = "@Nombre";
        public const string Estado = "@Estado";
        public const string Descripcion = "@Descripcion";

        public const string Retorno = "@CodigoRetorno";
    }
    public static class PA_INT_ELIMINAR_APLICATIVO
    {
        public const string NombreStoreProcedure = "PA_INT_ELIMINAR_APLICATIVO";
        public const string AplicativoCodigo = "@Codigo";

        public const string Retorno = "@CodigoRetorno";
    }
    
    public static class PA_SEG_ELIMINAR_PERMISO_MENU
    {
        public const string NombreStoreProcedure = "PA_SEG_ELIMINAR_PERMISO_MENU";
        public const string MenuCodigo = "@MenuCodigo";
        public const string RolCodigo = "@RolCodigo";
        public const string OpcionMenuCodigo = "@OpcionMenuCodigo";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_SEG_ELIMINAR_PERMISOS
    {
        public const string NombreStoreProcedure = "PA_SEG_ELIMINAR_PERMISOS";
        public const string PermisoCodigo = "@Codigo";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_OBTENER_LISTA_TODOS_APLICATIVOS
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_LISTA_TODOS_APLICATIVOS";
    }

    public static class PA_SEG_OBTENER_LISTA_TODOS_PERMISOS
    {
        public const string NombreStoreProcedure = "PA_SEG_OBTENER_LISTA_TODOS_PERMISOS";
    }

    public static class PA_INT_OBTENER_LISTA_APLICATIVOS
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_LISTA_APLICATIVOS";
        public const string NombreRed = "@NombreRed";
    }

    public static class PA_SEG_OBTENER_LISTA_PERMISOS
    {
        public const string NombreStoreProcedure = "PA_SEG_ACTUALIZAR_PERMISOS";
        public const string CodigoProyecto = "@CodigoProyecto";
    }

    public static class PA_INT_AGREGAR_CONTACTO
    {
        public const string NombreStoreProcedure = "PA_INT_AGREGAR_CONTACTO";
        public const string NombreRed = "@NombreRed";
        public const string Cargo = "@Cargo";
        public const string CorreoElectronico = "@CorreoElectronico";
        public const string Extension = "@Extension";
        public const string Descripcion = "@Descripcion";
        public const string Estado = "@Estado";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_ACTUALIZAR_CONTACTO
    {
        public const string NombreStoreProcedure = "PA_INT_ACTUALIZAR_CONTACTO";
        public const string NombreRed = "@NombreRed";
        public const string Cargo = "@Cargo";
        public const string CorreoElectronico = "@CorreoElectronico";
        public const string Extension = "@Extension";
        public const string Descripcion = "@Descripcion";
        public const string Estado = "@Estado";

        public const string Retorno = "@CodigoRetorno";
    }
    public static class PA_INT_ELIMINAR_CONTACTO
    {
        public const string NombreStoreProcedure = "PA_INT_ELIMINAR_CONTACTO";
        public const string NombreRed = "@NombreRed";

        public const string Retorno = "@CodigoRetorno";
    }

    public static class PA_INT_OBTENER_LISTA_CONTACTO
    {
        public const string NombreStoreProcedure = "PA_INT_OBTENER_LISTA_CONTACTO";
        public const string NombreRed = "@NombreRed";
    }

}
