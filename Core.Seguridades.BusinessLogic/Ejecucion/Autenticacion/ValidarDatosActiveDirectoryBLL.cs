using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Autenticacion
{
    public static class ValidarDatosActiveDirectoryBLL
    {
        public static void ValidarCamposVaciosAutenticacion(AutenticacionTrx objetoTransaccional)
        {
            if(objetoTransaccional.UsuarioAutenticacionRequest.NombreRedUsuario == null ||
                objetoTransaccional.UsuarioAutenticacionRequest.ContraseniaUsuario == null ||
                objetoTransaccional.UsuarioAutenticacionRequest.NombreRedUsuario == "" ||
                objetoTransaccional.UsuarioAutenticacionRequest.ContraseniaUsuario == "")
            {
                objetoTransaccional.Resultado.CodigoInternoRespuesta = (int)ErrorUsuario.CamposVaciosActenticacionActiveDirectory;
            }
        }
    }
}
