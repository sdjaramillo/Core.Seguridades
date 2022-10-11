using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using Core.Seguridades.Model.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Core.Common.DataAccess.Helper;
using Core.Common.Util.Helper.API;
using Core.Seguridades.Model.Entidad.Usuarios;

namespace Core.Seguridades.DataAccess.Usuarios
{
    public static class ObtenerUsuarioAdministradorDAL
    {
        internal class PA_SEG_OBTENER_PERMISO_ADMINISTRADOR_Result
        {
            public string MenuNombre { get; set; }
            public string OpcionNombre { get; set; }
            public string OpcionIcono { get; set; }
        }

        public static void Execute(UsuarioTrx objetoTransaccional)
        {
            string query = PA_SEG_OBTENER_PERMISO_ADMINISTRADOR.NombreStoreProcedure;
            DynamicParameters parametros;
            parametros = new DynamicParameters();
            parametros.Add(PA_SEG_OBTENER_PERMISO_ADMINISTRADOR.NombreRed, objetoTransaccional.RolAdministrador.NombreRed);
            parametros.Add(PA_SEG_OBTENER_PERMISO_ADMINISTRADOR.ProyectoCodigo, objetoTransaccional.RolAdministrador.ProyectoCodigo);

            DBConnectionHelper conexion = new DBConnectionHelper(Common.Model.General.EnumDBConnection.SqlConnection, SettingsHelper.ObtenerConnectionString("BD_SEGURIDADES"));
            List<PA_SEG_OBTENER_PERMISO_ADMINISTRADOR_Result> resultadoRolAdministrador = conexion.ObtenerListaDatos<PA_SEG_OBTENER_PERMISO_ADMINISTRADOR_Result>(query, parametros);

            objetoTransaccional.AdministradorUsuario.AddRange(AutoMapperHelper.MapeoDinamicoListasAutoMapper<Administrador, PA_SEG_OBTENER_PERMISO_ADMINISTRADOR_Result>(resultadoRolAdministrador));
            
        }
    }
}
