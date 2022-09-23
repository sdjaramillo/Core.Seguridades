using Core.Common.Model.ExcepcionServicio;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.Autenticacion;
using Core.Seguridades.Model.Transaccion.Transaccional.FuenteImagenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.FuenteImagenes
{
    public static class ValidarDatosFuenteImagenBLL
    {
        public static void ValidarCamposVaciosImagenRequest(ImagenesTrx objetoTransaccional)
        {
            if (objetoTransaccional.NuevaImagenRequest.Codigo == null ||
                objetoTransaccional.NuevaImagenRequest.EmpresaCodigo == null ||
                objetoTransaccional.NuevaImagenRequest.Nombre == null ||
                objetoTransaccional.NuevaImagenRequest.Tipo == null ||
                objetoTransaccional.NuevaImagenRequest.Valor == null ||
                objetoTransaccional.NuevaImagenRequest.FechaCreacion == null ||
                objetoTransaccional.NuevaImagenRequest.FechaCaducidad == null ||
                objetoTransaccional.NuevaImagenRequest.Descripcion == null ||
                objetoTransaccional.NuevaImagenRequest.Codigo == "" ||
                objetoTransaccional.NuevaImagenRequest.EmpresaCodigo == "" ||
                objetoTransaccional.NuevaImagenRequest.Nombre == "" ||
                objetoTransaccional.NuevaImagenRequest.Tipo == "" ||
                objetoTransaccional.NuevaImagenRequest.Valor == "" ||
                objetoTransaccional.NuevaImagenRequest.Descripcion == "")
            {
                throw new ExcepcionServicio((int)ErrorImagen.CamposVaciosImagenRequest);
            }
        }
    }
}
