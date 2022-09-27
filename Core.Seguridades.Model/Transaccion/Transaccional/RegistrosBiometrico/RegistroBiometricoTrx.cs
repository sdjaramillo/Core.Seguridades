using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.RegistroBiometrico;
using Core.Seguridades.Model.Entidad.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Request.RegistrosBiometrico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico
{
    public class RegistroBiometricoTrx : TransaccionBase
    {
        public RegistroBiometricoTrx()
        {
            ListaRegistroBiometrico = new List<RegistroBiometrico>();
            RegistroBiometricoNuevo = new RegistroBiometrico();
            RegistroBiometricoNuevoRequest = new AgregarRegistroBiometricoRequest();
            RegistroBiometricoRequest = new ObtenerListaRegistroBiometricoRequest();
            HoraEntradaEstablecida = new HorarioLaboral();
            ActualizarRegistroBiometrico = new ActualizarRegistroBiometricoRequest();
            AtrasosMesRequest = new ObtenerTotalAtrasosMesRequest();
            NombreRed = "";
        }

        public List<RegistroBiometrico> ListaRegistroBiometrico { get; set; }
        public ObtenerListaRegistroBiometricoRequest RegistroBiometricoRequest { get; set; }
        public AgregarRegistroBiometricoRequest RegistroBiometricoNuevoRequest { get; set; }
        public RegistroBiometrico RegistroBiometricoNuevo { get; set; }
        public HorarioLaboral HoraEntradaEstablecida { get; set; }
        public int AtrasosMes { get; set; }
        public string NombreRed { get; set; }
        public ActualizarRegistroBiometricoRequest ActualizarRegistroBiometrico { get; set; }
        public ObtenerTotalAtrasosMesRequest AtrasosMesRequest { get; set; }

    }
}
