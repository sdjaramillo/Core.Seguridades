using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.DataAccess.General;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.CredencialesAccesos;
using Dapper;
using Microsoft.Extensions.Configuration;


namespace Core.Seguridades.DataAccess.CredencialesAccesos
{
    public static class ValidarCredencialAccesoExisteDAL
    {
        /// <summary>
        /// Procedimiento almacenado para validar si existe un usuario
        /// </summary>
        /// <param name="objetoTransaccional"></param>
        public static void Execute(CredencialAccesoTrx objetoTransaccional)
        {
            DBConnectionHelper coneccion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("LocalCon"));
            var dynamicParameters = new DynamicParameters();

            dynamicParameters.Add(ConstantesPA.PA_SEG_VALIDAAR_CREDENCIALES_ACCESO_EXISTE.PARAM_USUARIO, objetoTransaccional.CredencialAcceso.Usuario, System.Data.DbType.String);
            dynamicParameters.Add(ConstantesPA.PA_SEG_VALIDAAR_CREDENCIALES_ACCESO_EXISTE.PARAM_CLAVE, objetoTransaccional.CredencialAcceso.Clave, System.Data.DbType.String);
            dynamicParameters.Add(ConstantesPA.PA_SEG_VALIDAAR_CREDENCIALES_ACCESO_EXISTE.PARAM_TIPO, objetoTransaccional.CredencialAcceso.Cat_id_tipo, System.Data.DbType.String);
            dynamicParameters.Add(ConstantesPA.PA_SEG_VALIDAAR_CREDENCIALES_ACCESO_EXISTE.PATAM_ENTIDAD, objetoTransaccional.CredencialAcceso.EntidadId, System.Data.DbType.Int32);

            dynamicParameters.Add(ConstantesPA.CodigoRetorno, System.Data.DbType.Int32, direction: System.Data.ParameterDirection.ReturnValue);

            var result = coneccion.Ejecutar<int>(ConstantesPA.PA_SEG_VALIDAAR_CREDENCIALES_ACCESO_EXISTE.PA_NOMBRE, dynamicParameters);
            if (result != (int)Error.OperacionExitosa)
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = result;
        }
    }
}
