using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.MenuDinamico;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.MenuDinamico
{
    public static class ObtenerLogoEmpresaDAL
    {

        public static void Execute(MenusTrx objetoTransaccional)
        {
            string query = PA_SEG_OBTENER_LOGO_EMPRESA.NombreStoreProcedure;
            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_SEG_OBTENER_LOGO_EMPRESA.NombreRed, objetoTransaccional.PeticionLogo.NombreRed);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            List<string> resultadoLogoEmpresa = conexion.ObtenerListaDatos<string>(query, parametros);

            objetoTransaccional.ValorLogo = resultadoLogoEmpresa.First().ToString();
        }
    }
}
