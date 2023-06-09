﻿using System.Data.SqlClient;
using Core.Seguridades.Model.General;
using Dapper;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Common.Util.Helper.API;
using Core.Common.DataAccess.Helper;

using Microsoft.Extensions.Configuration;

namespace Core.Seguridades.DataAccess.Usuarios
{
    /// <summary>
    /// Lógica de acceso de los datos que permite obtener la lista de usuarios
    /// </summary>
    public static class ObtenerListaUsuariosDAL
    {
        /// <summary>
        /// Estrucutra interna de la respuesta al obtener la información de la BD
        /// </summary>
        internal class PA_OBTENER_LISTA_USUARIOS_Result
        {
            public int Id { get; set; }
            public string CodigoHorarioLaboral { get; set; }
            public string CodigoEmpresa { get; set; }
            public string NombreRed { get; set; }
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public string Ciudad { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public DateTime FechaIngreso { get; set; }
            public DateTime FechaSalida { get; set; }
            public string Imagen { get; set; }
            public string CorreoElectronico { get; set; }
            public Boolean Estado { get; set; }
            public string Descripcion { get; set; }

        }

        /// <summary>
        /// Método que ejecuta la obtención de los datos de la tabla SEG_USUARIO de la BD
        /// </summary>
        /// <param name="objetoTransaccional">Objeto transaccional de usuario</param>
        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            
            string query = PA_SEG_OBTENER_LISTA_USUARIOS.NombreStoreProcedure;
            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            List<PA_OBTENER_LISTA_USUARIOS_Result> resultadoListaUsuarios=conexion.ObtenerListaDatos<PA_OBTENER_LISTA_USUARIOS_Result>(query);


            objetoTransaccional.ListaUsuarios.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Usuario, PA_OBTENER_LISTA_USUARIOS_Result>(resultadoListaUsuarios));

            /*using (var connection = new SqlConnection(new DB_Connection().connDB_name))
            {
                foreach (var usuario in connection.Query<PA_OBTENER_LISTA_USUARIOS_Result>(query).ToList())
                {
                    objetoTransaccional.ListaUsuarios.Add(AutoMapperHelper.MapeoDinamicoSimpleAutoMapper<Usuario, PA_OBTENER_LISTA_USUARIOS_Result>(usuario));
                }
            }*/
        }
    }
}
