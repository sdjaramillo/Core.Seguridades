using Core.Common.Util.Helper.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion
{
    public static class GenerarTokenBLL
    {        
        /// <summary>
        /// Metodo para generar JWTOKEn
        /// </summary>
        /// <param name="objetoTransaccional"></param>
        public static void GenerarToken(AutenticacionTrx objetoTransaccional)
        {
            var claims = new Dictionary<string, string>();

            //USUARIO
            claims.Add("Usuario", objetoTransaccional.CredencialAcceso.Usuario);
            //CLAVE
            claims.Add("Password", objetoTransaccional.CredencialAcceso.Clave);
            //TIPO
            claims.Add("Tipo", objetoTransaccional.CredencialAcceso.Cat_id_tipo.ToString());
            //ENTIDAD
            claims.Add("Entidad", objetoTransaccional.CredencialAcceso.EntidadId.ToString());
           
            var token = JwtHelper.GenerarJWT(claims);
            objetoTransaccional.TokenJWT = token;            
        }
    }
}
