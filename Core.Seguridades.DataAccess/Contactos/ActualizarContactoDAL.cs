using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;
using Dapper;
using System.Data;

namespace Core.Seguridades.DataAccess.Contactos
{
    public static class ActualizarContactoDAL
    {
        public static void Execute(ContactosTrx objetoTransaccional)
        {
            string query = PA_INT_ACTUALIZAR_CONTACTO.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_ACTUALIZAR_CONTACTO.NombreRed, objetoTransaccional.ContactoRequest.NombreRed);
            parametros.Add(PA_INT_ACTUALIZAR_CONTACTO.Cargo, objetoTransaccional.ContactoRequest.Cargo);
            parametros.Add(PA_INT_ACTUALIZAR_CONTACTO.CorreoElectronico, objetoTransaccional.ContactoRequest.CorreoElectronico);
            parametros.Add(PA_INT_ACTUALIZAR_CONTACTO.Extension, objetoTransaccional.ContactoRequest.Extension);
            parametros.Add(PA_INT_ACTUALIZAR_CONTACTO.Descripcion, objetoTransaccional.ContactoRequest.Descripcion);
            parametros.Add(PA_INT_ACTUALIZAR_CONTACTO.Estado, objetoTransaccional.ContactoRequest.Estado);
            parametros.Add(PA_INT_ACTUALIZAR_CONTACTO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Actualizar(query, parametros);

            if (parametros.Get<int>(PA_INT_ACTUALIZAR_APLICATIVO.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.NoExisteAplicativoBaseDatos;
            }
        }
    }
}
