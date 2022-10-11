using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.DataAccess.General;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.Autenticacion
{
    public static class AutenticarCredencialesAccesoDAL
    {
        /// <summary>
        /// Autentica una credencial de acceso
        /// </summary>
        /// <param name="objetoTransaccional">
        /// CredencialAcceso
        /// </param>
        public static AutenticarCredencialesAccesoResult ValidarCredencialesAcceso(AutenticacionTrx objetoTransaccional)
        {
            DBConnectionHelper coneccion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("LocalCon"));
            var dynamicParameters = new DynamicParameters();

            dynamicParameters.Add(ConstantesPA.PA_SEG_AUTENTICAR_CREDENCIALES_ACCESO.PARAM_USUARIO, objetoTransaccional.CredencialAcceso.Usuario, System.Data.DbType.String);
            dynamicParameters.Add(ConstantesPA.PA_SEG_AUTENTICAR_CREDENCIALES_ACCESO.PARAM_CLAVE, objetoTransaccional.CredencialAcceso.Clave, System.Data.DbType.String);

            var resultCredencialesAcceso = coneccion.ObtenerListaDatos<AutenticarCredencialesAccesoResult>(ConstantesPA.PA_SEG_AUTENTICAR_CREDENCIALES_ACCESO.PA_NOMBRE, dynamicParameters);

            return (resultCredencialesAcceso.Count > 0) ? resultCredencialesAcceso.First() : null;
        }

        /// <summary>
        /// Clase result para procedimiento almacenado PA_SEG_VALIDAR_CREDENCIALES_ACCESO
        /// </summary>
        public class AutenticarCredencialesAccesoResult
        {
            public string Usuario { get; set; }
            public string Clave { get; set; }
            public string Tipo { get; set; }
            public string EntidadID { get; set; }
        }
    }
}
