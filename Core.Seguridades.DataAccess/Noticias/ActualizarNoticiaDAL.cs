using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Noticias;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.DataAccess.Noticias
{
    public static class ActualizarNoticiaDAL
    {
        public static void Execute(NoticiaTrx objetoTransaccional)
        {
            string query = PA_INT_ACTUALIZAR_NOTICIA.NombreStoreProcedure;


            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_INT_ACTUALIZAR_NOTICIA.CodigoNoticia, objetoTransaccional.NoticiaRequest.Codigo);
            parametros.Add(PA_INT_ACTUALIZAR_NOTICIA.CodigoPermisoPublicacion, objetoTransaccional.NoticiaRequest.CodigoPermisoPublicacion);
            parametros.Add(PA_INT_ACTUALIZAR_NOTICIA.Titulo, objetoTransaccional.NoticiaRequest.Titulo);
            parametros.Add(PA_INT_ACTUALIZAR_NOTICIA.Imagen, objetoTransaccional.NoticiaRequest.Imagen);
            parametros.Add(PA_INT_ACTUALIZAR_NOTICIA.Descripcion, objetoTransaccional.NoticiaRequest.Descripcion);
            parametros.Add(PA_INT_ACTUALIZAR_NOTICIA.Publico, objetoTransaccional.NoticiaRequest.Publico);

            parametros.Add(PA_INT_ACTUALIZAR_NOTICIA.Retorno, System.Data.DbType.Int32, direction: ParameterDirection.ReturnValue);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_INTRANET"));
            conexion.Actualizar(query, parametros);

            if (parametros.Get<int>(PA_INT_ACTUALIZAR_NOTICIA.Retorno) != 10000)
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorAplicativo.NoExisteAplicativoBaseDatos;
            }
        }
    }
}
