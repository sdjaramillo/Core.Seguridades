using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.Usuarios
{
    public static class ObtenerListaCumpleaniosDAL
    {
        internal class PA_SEG_OBTENER_LISTA_CUMPLEANIERO_MES_Result
        {
            public string Nombres { get; set; }
            public string Apellidos { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string Imagen { get; set; }
            public string Descripcion { get; set; }

        }

        public static void Execute(UsuarioTrx objetoTransaccional)
        {

            string query = PA_SEG_OBTENER_LISTA_CUMPLEANIERO_MES.NombreStoreProcedure;
            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, new DB_Connection().connDB_name);
            List<PA_SEG_OBTENER_LISTA_CUMPLEANIERO_MES_Result> resultadoListaCumpleanieros = conexion.ObtenerListaDatos<PA_SEG_OBTENER_LISTA_CUMPLEANIERO_MES_Result>(query);


            objetoTransaccional.ListaCumpleanieros.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<CumpleanieroMes, PA_SEG_OBTENER_LISTA_CUMPLEANIERO_MES_Result>(resultadoListaCumpleanieros));

        }
    }
}
