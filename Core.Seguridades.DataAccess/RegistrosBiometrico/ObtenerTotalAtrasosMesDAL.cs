using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.RegistrosBiometrico
{
    public static class ObtenerTotalAtrasosMesDAL
    {
        internal class PA_INT_OBTENER_TOTAL_ATRASOS_MES_Result
        {
            public int TotalDiasAtraso { get; set; }

        }
        public static void Execute(RegistroBiometricoTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_TOTAL_ATRASOS_MES.NombreStoreProcedure;
            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_OBTENER_TOTAL_ATRASOS_MES.NombreRed, objetoTransaccional.RegistroBiometricoNuevo.UsuarioCodigo);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, new DB_Connection().connDB_intranet);
            List<PA_INT_OBTENER_TOTAL_ATRASOS_MES_Result> resultadoListaUsuarios = conexion.ObtenerListaDatos<PA_INT_OBTENER_TOTAL_ATRASOS_MES_Result>(query, parametros);


            objetoTransaccional.AtrasosMes = resultadoListaUsuarios.First().TotalDiasAtraso;
            if (objetoTransaccional.RegistroBiometricoNuevo.TiempoAtraso > 0)
            {
                objetoTransaccional.AtrasosMes++;
            }
        }
    }
}
