using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.FuenteImagenes;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.FuenteImagenes
{
    public static class ObtenerTodaFuenteImagenDAL
    {
        internal class PA_INT_OBTENER_TODAS_IMAGENES_Result
        {
            public string Id { get; set; }
            public string Codigo { get; set; }
            public string EmpresaCodigo { get; set; }
            public string Nombre { get; set; }
            public string Tipo { get; set; }
            public string Valor { get; set; }
            public bool Estado { get; set; }
            public DateTime FechaCreacion { get; set; }
            public DateTime FechaCaducidad { get; set; }
            public string Descripcion {  get; set; }
        }

        public static void Execute(ImagenesTrx objetoTransaccional)
        {
            string query = PA_INT_OBTENER_TODAS_IMAGENES.NombreStoreProcedure;
            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            List<PA_INT_OBTENER_TODAS_IMAGENES_Result> resultadoListaImagen = conexion.ObtenerListaDatos<PA_INT_OBTENER_TODAS_IMAGENES_Result>(query);

            objetoTransaccional.ListaImagenTotal.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Imagen, PA_INT_OBTENER_TODAS_IMAGENES_Result>(resultadoListaImagen));
        }
    }
}
