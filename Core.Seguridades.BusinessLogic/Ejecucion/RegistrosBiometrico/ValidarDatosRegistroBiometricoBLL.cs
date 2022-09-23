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
            if (objetoTransaccional.RegistroBiometricoNuevoRequest.NombreRed != null ||
                objetoTransaccional.RegistroBiometricoNuevoRequest.Codigo != null ||
                objetoTransaccional.RegistroBiometricoNuevoRequest.FechaRegistro != null ||
                objetoTransaccional.RegistroBiometricoNuevoRequest.HoraEntrada != null ||
                objetoTransaccional.RegistroBiometricoNuevoRequest.IpRegistro != null ||
                objetoTransaccional.RegistroBiometricoNuevoRequest.PcNombre != null
                )
            {
                objetoTransaccional.AtrasosMesRequest.NombreRed = objetoTransaccional.RegistroBiometricoNuevoRequest.NombreRed;
                objetoTransaccional.RegistroBiometricoNuevo.UsuarioCodigo = objetoTransaccional.RegistroBiometricoNuevoRequest.NombreRed;
                objetoTransaccional.RegistroBiometricoNuevo.Codigo = objetoTransaccional.RegistroBiometricoNuevoRequest.Codigo;
                objetoTransaccional.RegistroBiometricoNuevo.FechaRegistro = objetoTransaccional.RegistroBiometricoNuevoRequest.FechaRegistro;
                objetoTransaccional.RegistroBiometricoNuevo.HoraEntrada = TimeSpan.Parse(objetoTransaccional.RegistroBiometricoNuevoRequest.HoraEntrada);
                objetoTransaccional.RegistroBiometricoNuevo.IpRegistro = objetoTransaccional.RegistroBiometricoNuevoRequest.IpRegistro;
                objetoTransaccional.RegistroBiometricoNuevo.PcNombre = objetoTransaccional.RegistroBiometricoNuevoRequest.PcNombre;
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
            if (objetoTransaccional.RegistroBiometricoNuevoRequest.NombreRed != null ||
                objetoTransaccional.RegistroBiometricoNuevoRequest.Codigo != null ||
                objetoTransaccional.RegistroBiometricoNuevoRequest.FechaRegistro != null ||
                objetoTransaccional.RegistroBiometricoNuevoRequest.HoraEntrada != null ||
                objetoTransaccional.RegistroBiometricoNuevoRequest.IpRegistro != null ||
                objetoTransaccional.RegistroBiometricoNuevoRequest.PcNombre != null
                )
            {
                objetoTransaccional.RegistroBiometricoNuevo.UsuarioCodigo = objetoTransaccional.ActualizarRegistroBiometrico.NombreRed;
                objetoTransaccional.RegistroBiometricoNuevo.Codigo = objetoTransaccional.ActualizarRegistroBiometrico.Codigo;
                objetoTransaccional.RegistroBiometricoNuevo.FechaRegistro = objetoTransaccional.ActualizarRegistroBiometrico.FechaRegistro;
                objetoTransaccional.RegistroBiometricoNuevo.HoraEntrada = TimeSpan.Parse(objetoTransaccional.ActualizarRegistroBiometrico.HoraEntrada);
                objetoTransaccional.RegistroBiometricoNuevo.IpRegistro = objetoTransaccional.ActualizarRegistroBiometrico.IpRegistro;
                objetoTransaccional.RegistroBiometricoNuevo.PcNombre = objetoTransaccional.ActualizarRegistroBiometrico.PcNombre;
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
