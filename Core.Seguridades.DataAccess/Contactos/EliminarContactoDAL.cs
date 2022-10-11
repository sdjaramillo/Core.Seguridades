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
    public static class EliminarContactoDAL
    {
        public static void Execute(ContactosTrx objetoTransaccional)
        {
            string query = PA_INT_ELIMINAR_CONTACTO.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_ELIMINAR_CONTACTO.NombreRed, objetoTransaccional.ContactoCodigo);
            parametros.Add(PA_INT_ELIMINAR_CONTACTO.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Eliminar(query, parametros);

            if (parametros.Get<int>(PA_INT_ELIMINAR_CONTACTO.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.NoExisteAplicativoBaseDatos;
                //throw new ExcepcionServicio((int)ErrorAplicativo.NoExisteAplicativoBaseDatos);
            }
        }
    }
}
