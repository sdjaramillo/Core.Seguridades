using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Contactos;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Contactos;
using Dapper;

namespace Core.Seguridades.DataAccess.Contactos
{
    public static class ObtenerListaContactoDAL
    {
        internal class PA_INT_OBTENER_LISTA_CONTACTO_Result
        {
            public string NombreRed {get;set;}
            public string Cargo{get;set;}
            public string CorreoElectronico{get;set;}
            public string Extension {get;set;}
            public string Descripcion { get; set; }
        }
        public static void Execute(ContactosTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_LISTA_CONTACTO.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_OBTENER_LISTA_CONTACTO.NombreRed, objetoTransaccional.NombreRed);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            List<PA_INT_OBTENER_LISTA_CONTACTO_Result> resultadoListaContactos = conexion.ObtenerListaDatos<PA_INT_OBTENER_LISTA_CONTACTO_Result>(query, parametros);

            objetoTransaccional.ListaContactos.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Contacto, PA_INT_OBTENER_LISTA_CONTACTO_Result>(resultadoListaContactos));

        }
    }
}
