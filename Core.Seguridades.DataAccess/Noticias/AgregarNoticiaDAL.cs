using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.FuenteImagenes;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;
using Dapper;
using System.Data;

namespace Core.Seguridades.DataAccess.Noticias
{
    public static class AgregarNoticiaDAL
    {
        internal class PA_INT_AGREGAR_NOTICIA_Result
        {
            public string CodigoPermisoPublicacion { get; set; }
            public string Codigo { get; set; }
            public string Titulo { get; set; }
            public string Imagen { get; set; }
            public string Descripcion { get; set; }
            public bool Publico { get; set; }
        }

        public static void Execute (NoticiaTrx objetoTransaccional)
        {
            string query = PA_INT_AGREGAR_NOTICIA.NombreStoreProcedure;

            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_AGREGAR_NOTICIA.CodigoPermisoPublicacion, objetoTransaccional.NoticiaRequest.CodigoPermisoPublicacion);
            parametros.Add(PA_INT_AGREGAR_NOTICIA.Codigo, objetoTransaccional.NoticiaRequest.Codigo);
            parametros.Add(PA_INT_AGREGAR_NOTICIA.Titulo, objetoTransaccional.NoticiaRequest.Titulo);
            parametros.Add(PA_INT_AGREGAR_NOTICIA.Imagen, objetoTransaccional.NoticiaRequest.Imagen);
            parametros.Add(PA_INT_AGREGAR_NOTICIA.Descripcion, objetoTransaccional.NoticiaRequest.Descripcion);
            parametros.Add(PA_INT_AGREGAR_NOTICIA.Publico, objetoTransaccional.NoticiaRequest.Publico);
            parametros.Add(PA_INT_AGREGAR_NOTICIA.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));

            conexion.InsertarDatos(query, parametros);

            if (parametros.Get<int>(PA_INT_AGREGAR_NOTICIA.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorNoticia.NoExistePermisoPublicacion;
            }
        }
    }
}
