using Core.Common.Util.Helper.Datos;
using Core.Seguridades.Model.Entidad.RegistroBiometrico;
using Core.Seguridades.Model.General;
using Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.BusinessLogic.Ejecucion.RegistrosBiometrico
{
    public static class ValidarDatosRegistroBiometricoBLL
    {
        public static void ValidarParametrosVaciosRegistroNuevo(RegistroBiometricoTrx objetoTransaccional)
        {
            if (objetoTransaccional.RegistroBiometricoRequest.NombreRed != null ||
                objetoTransaccional.RegistroBiometricoRequest.Codigo != null ||
                objetoTransaccional.RegistroBiometricoRequest.FechaRegistro != null ||
                objetoTransaccional.RegistroBiometricoRequest.HoraEntrada != null ||
                objetoTransaccional.RegistroBiometricoRequest.IpRegistro != null ||
                objetoTransaccional.RegistroBiometricoRequest.PcNombre != null
                )
            {
                objetoTransaccional.NombreRed = objetoTransaccional.RegistroBiometricoRequest.NombreRed;
                objetoTransaccional.RegistroBiometricoNuevo.NombreRed = objetoTransaccional.RegistroBiometricoRequest.NombreRed;
                objetoTransaccional.RegistroBiometricoNuevo.Codigo = objetoTransaccional.RegistroBiometricoRequest.Codigo;
                objetoTransaccional.RegistroBiometricoNuevo.FechaRegistro = objetoTransaccional.RegistroBiometricoRequest.FechaRegistro;
                objetoTransaccional.RegistroBiometricoNuevo.HoraEntrada = TimeSpan.Parse(objetoTransaccional.RegistroBiometricoRequest.HoraEntrada);
                objetoTransaccional.RegistroBiometricoNuevo.IpRegistro = objetoTransaccional.RegistroBiometricoRequest.IpRegistro;
                objetoTransaccional.RegistroBiometricoNuevo.PcNombre = objetoTransaccional.RegistroBiometricoRequest.PcNombre;
                string VariableSistemaAtraso = VariablesSistemaHelper.ObtenerValor(ConstantesVariablesSistema.TIEMPO_ATRASO_EMPLEADO);
                TimeSpan HoraAtraso = TimeSpan.Parse(VariableSistemaAtraso);
                HoraAtraso = objetoTransaccional.HoraEntradaEstablecida.HoraEntrada.Add(TimeSpan.FromMinutes(HoraAtraso.Minutes));
                HoraAtraso = objetoTransaccional.RegistroBiometricoNuevo.HoraEntrada - HoraAtraso;
                if (HoraAtraso.TotalSeconds>0)
                {
                    objetoTransaccional.RegistroBiometricoNuevo.TiempoAtraso = float.Parse(HoraAtraso.TotalSeconds.ToString());
                }
            }
        }
        public static void ValidarParametrosVaciosRegistroActualizar(RegistroBiometricoTrx objetoTransaccional)
        {
            if (objetoTransaccional.RegistroBiometricoRequest.NombreRed != null ||
                objetoTransaccional.RegistroBiometricoRequest.Codigo != null ||
                objetoTransaccional.RegistroBiometricoRequest.FechaRegistro != null ||
                objetoTransaccional.RegistroBiometricoRequest.HoraEntrada != null ||
                objetoTransaccional.RegistroBiometricoRequest.IpRegistro != null ||
                objetoTransaccional.RegistroBiometricoRequest.PcNombre != null
                )
            {
                objetoTransaccional.RegistroBiometricoNuevo.NombreRed = objetoTransaccional.RegistroBiometricoRequest.NombreRed;
                objetoTransaccional.RegistroBiometricoNuevo.Codigo = objetoTransaccional.RegistroBiometricoRequest.Codigo;
                objetoTransaccional.RegistroBiometricoNuevo.FechaRegistro = objetoTransaccional.RegistroBiometricoRequest.FechaRegistro;
                objetoTransaccional.RegistroBiometricoNuevo.HoraEntrada = TimeSpan.Parse(objetoTransaccional.RegistroBiometricoRequest.HoraEntrada);
                objetoTransaccional.RegistroBiometricoNuevo.IpRegistro = objetoTransaccional.RegistroBiometricoRequest.IpRegistro;
                objetoTransaccional.RegistroBiometricoNuevo.PcNombre = objetoTransaccional.RegistroBiometricoRequest.PcNombre;
                string VariableSistemaAtraso = VariablesSistemaHelper.ObtenerValor(ConstantesVariablesSistema.TIEMPO_ATRASO_EMPLEADO);
                TimeSpan HoraAtraso = TimeSpan.Parse(VariableSistemaAtraso);
                HoraAtraso = objetoTransaccional.HoraEntradaEstablecida.HoraEntrada.Add(TimeSpan.FromMinutes(HoraAtraso.Minutes));
                HoraAtraso = objetoTransaccional.RegistroBiometricoNuevo.HoraEntrada - HoraAtraso;
                if (HoraAtraso.TotalSeconds > 0)
                {
                    objetoTransaccional.RegistroBiometricoNuevo.TiempoAtraso = float.Parse(HoraAtraso.TotalSeconds.ToString());
                }
            }
        }
    }
}
