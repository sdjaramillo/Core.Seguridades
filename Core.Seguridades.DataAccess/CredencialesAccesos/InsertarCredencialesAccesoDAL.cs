using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.DataAccess.General;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.CredencialesAccesos;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.CredencialesAccesos
{
    /// <summary>
    /// ´Proceidmiento almacenado para insertar nueva entidad credencial acceso
    /// </summary>
    public static class InsertarCredencialesAccesoDAL
    {
        public static void Execute(CredencialAccesoTrx objetoTransaccional)
        {
            DBConnectionHelper coneccion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("LocalCon"));
            var dynamicParameters = new DynamicParameters();            

            dynamicParameters.Add(ConstantesPA.PA_SEG_INSERTAR_CREDENCIALES_ACCESO.PARAM_USUARIO, objetoTransaccional.CredencialAcceso.Usuario, System.Data.DbType.String);
            dynamicParameters.Add(ConstantesPA.PA_SEG_INSERTAR_CREDENCIALES_ACCESO.PARAM_CLAVE, objetoTransaccional.CredencialAcceso.Clave, System.Data.DbType.String);
            dynamicParameters.Add(ConstantesPA.PA_SEG_INSERTAR_CREDENCIALES_ACCESO.PARAM_TIPO, objetoTransaccional.CredencialAcceso.Cat_id_tipo, System.Data.DbType.String);
            dynamicParameters.Add(ConstantesPA.PA_SEG_INSERTAR_CREDENCIALES_ACCESO.PARAM_CODIGO_ENTIDAD, objetoTransaccional.CredencialAcceso.EntidadId, System.Data.DbType.Int32);

            dynamicParameters.Add(ConstantesPA.CodigoRetorno, System.Data.DbType.Int32, direction: System.Data.ParameterDirection.ReturnValue);

            var resultado = coneccion.InsertarDatos(ConstantesPA.PA_SEG_INSERTAR_CREDENCIALES_ACCESO.PA_NOMBRE, dynamicParameters);
            if (resultado != (int)Error.OperacionExitosa)
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = resultado;
        }
    }
}
