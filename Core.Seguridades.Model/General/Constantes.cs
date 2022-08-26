﻿using System;
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
    public static class PA_OBTENER_LISTA_USUARIOS
    {
        public const string NombreStoreProcedure = "PA_OBTENER_LISTA_USUARIOS";
    }

    /// <summary>
    /// Parametos para agregar la lista de usuarios mediante el procedimiento almacenado
    /// </summary>
    public static class PA_AGREGAR_LISTA_USUARIOS
    {
        public const string NombreStoreProcedure = "PA_AGREGAR_LISTA_USUARIOS";
        public const string NombreRedUsuario = "@NombreRedUsuario";
        public const string NombreUsuario = "@NombreUsuario";
        public const string ApellidoUsuario = "@ApellidoUsuario";
        public const string NombreEmpresa = "@NombreEmpresa";
        public const string FechaIngresoUsuario = "@FechaIngresoUsuario";
        public const string CorreoElectronicoUsuario = "@CorreoElectronicoUsuario";
        public const string Retorno = "@RESULT";
    }

    /// <summary>
    /// Parametos para migrar la lista de usaurios almacenados en active directory
    /// </summary>
    public static class MigrarUsuariosActiveDirectoryConstantes
    {
        public const string IdentificarEmpresa = "OU";
    }
}
