using Core.Seguridades.Model.Entidad.Usuarios;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    public static class ValidarEmpresasSistemaBLL
    {
        public static void ExistenciaEmpresasBaseDatos(UsuarioTrx objetoTransaccional)
        {
            List<UsuarioActiveDirectory> listaUsuariosNuevos = objetoTransaccional.ListaUsuariosNuevos.ToList();
            if(listaUsuariosNuevos.Count > 0)
            {
                objetoTransaccional.ListaUsuariosNuevos.Clear();
                foreach (string codigoEmpresa in ConstantesInicialesEmpresas.InicalesEmpresas)
                {
                    try
                    {
                        var usuarioVerificado = listaUsuariosNuevos.FindAll(x => x.NombreEmpresa == codigoEmpresa);
                        objetoTransaccional.ListaUsuariosNuevos.AddRange(usuarioVerificado);
                    }
                    catch
                    {
                        objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorUsuario.NoExisteNombreEmpresaAsignada;
                    }
                }
            }
            else
            {
                objetoTransaccional.Respuesta.CodigoInternoRespuesta = (int)ErrorUsuario.NoExisteNombreEmpresaAsignada;
            }
            objetoTransaccional.CantidadUsuariosNuevos = objetoTransaccional.ListaUsuariosNuevos.Count;
        }
    }
}
