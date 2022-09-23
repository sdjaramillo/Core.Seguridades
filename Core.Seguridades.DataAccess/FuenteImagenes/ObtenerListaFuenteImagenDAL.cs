using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.FuenteImagenes;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using Dapper;

namespace Core.Seguridades.DataAccess.FuenteImagenes
{
    public static class ObtenerListaFuenteImagenDAL
    {
        internal class PA_OBTENER_LISTA_IMAGENES_Result
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Valor { get; set; }
            public DateTime FechaCreacion { get; set; }
        }
        public static void Execute(ImagenesTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_LISTA_IMAGENES.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_OBTENER_LISTA_IMAGENES.NombreRed, objetoTransaccional.ImagenRequest.NombreRed);
            parametros.Add(PA_INT_OBTENER_LISTA_IMAGENES.Tipo, objetoTransaccional.ImagenRequest.Tipo);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            List<PA_OBTENER_LISTA_IMAGENES_Result> resultadoListaImagenes = conexion.ObtenerListaDatos<PA_OBTENER_LISTA_IMAGENES_Result>(query, parametros);

            objetoTransaccional.ListaImagen.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Imagen, PA_OBTENER_LISTA_IMAGENES_Result>(resultadoListaImagenes));
        }
    }
}
    
