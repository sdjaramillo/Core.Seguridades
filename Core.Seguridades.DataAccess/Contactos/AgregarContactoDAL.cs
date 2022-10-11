using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.Contactos
{
    public static class AgregarContactoDAL
    {
        internal class PA_INT_AGREGAR_CONTACTO_Result
        {
            public string NombreRed { get; set; }
            public string Cargo { get; set; }
            public string CorreoElectronico { get; set; }
            public int Extension { get; set; }
            public string Descripcion { get; set; }
        }
        public static void Execute(ContactosTrx objetoTransaccional)
        {
            string query = PA_INT_AGREGAR_CONTACTO.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros=new DynamicParameters();
            parametros.Add(PA_INT_AGREGAR_CONTACTO.NombreRed, objetoTransaccional.ContactoRequest.NombreRed);
            parametros.Add(PA_INT_AGREGAR_CONTACTO.Cargo, objetoTransaccional.ContactoRequest.Cargo);
            parametros.Add(PA_INT_AGREGAR_CONTACTO.CorreoElectronico, objetoTransaccional.ContactoRequest.CorreoElectronico);
            parametros.Add(PA_INT_AGREGAR_CONTACTO.Extension, objetoTransaccional.ContactoRequest.Extension);
            parametros.Add(PA_INT_AGREGAR_CONTACTO.Descripcion, objetoTransaccional.ContactoRequest.Descripcion);
            parametros.Add(PA_INT_AGREGAR_CONTACTO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.InsertarDatos(query, parametros);
        }
    }
}
