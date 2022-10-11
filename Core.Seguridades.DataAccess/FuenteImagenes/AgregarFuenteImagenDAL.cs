using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using Dapper;
using Core.Common.DataAccess.Helper;
using System.Data;
using Core.Common.Util.Helper.API;

namespace Core.Seguridades.DataAccess.FuenteImagenes
{
    public static class AgregarFuenteImagenDAL
    {
        internal class PA_INT_AGREGAR_IMAGEN_Result
        {
            public string Codigo { get; set; }
            public string EmpresaCodigo { get; set; }
            public string Nombre { get; set; }
            public string Tipo { get; set; }
            public string Valor { get; set; }
            public DateTime FechaCreacion { get; set; }
            public DateTime FechaCaducidad { get; set; }
            public string Descripcion { get; set; }
        }
        public static void Execute(ImagenesTrx objetoTransaccional)
        {
            string query = PA_INT_AGREGAR_IMAGEN.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_AGREGAR_IMAGEN.Nombre, objetoTransaccional.NuevaImagenRequest.Nombre);
            parametros.Add(PA_INT_AGREGAR_IMAGEN.Codigo, objetoTransaccional.NuevaImagenRequest.Codigo);
            parametros.Add(PA_INT_AGREGAR_IMAGEN.EmpresaCodigo, objetoTransaccional.NuevaImagenRequest.EmpresaCodigo);
            parametros.Add(PA_INT_AGREGAR_IMAGEN.Nombre, objetoTransaccional.NuevaImagenRequest.Nombre);
            parametros.Add(PA_INT_AGREGAR_IMAGEN.Tipo, objetoTransaccional.NuevaImagenRequest.Tipo);
            parametros.Add(PA_INT_AGREGAR_IMAGEN.Valor, objetoTransaccional.NuevaImagenRequest.Valor);
            parametros.Add(PA_INT_AGREGAR_IMAGEN.FechaCreacion, objetoTransaccional.NuevaImagenRequest.FechaCreacion);
            parametros.Add(PA_INT_AGREGAR_IMAGEN.FechaCaducidad, objetoTransaccional.NuevaImagenRequest.FechaCaducidad);
            parametros.Add(PA_INT_AGREGAR_IMAGEN.Descripcion, objetoTransaccional.NuevaImagenRequest.Descripcion);
            parametros.Add(PA_INT_AGREGAR_IMAGEN.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));

            conexion.InsertarDatos(query, parametros);

            if (parametros.Get<int>(PA_INT_AGREGAR_IMAGEN.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorImagen.NoExisteNombreEmpresaAsignada;
            }
        }
    }
}
