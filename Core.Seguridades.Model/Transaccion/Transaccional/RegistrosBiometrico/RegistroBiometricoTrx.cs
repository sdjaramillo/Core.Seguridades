using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.RegistroBiometrico;
using Core.Seguridades.Model.Entidad.RegistrosBiometrico;
using Core.Seguridades.Model.Transaccion.Request.RegistrosBiometrico;

namespace Core.Seguridades.Model.Transaccion.Transaccional.RegistrosBiometrico
{
    public class RegistroBiometricoTrx : TransaccionBase
    {
        public RegistroBiometricoTrx()
        {
            ListaRegistroBiometrico = new List<RegistroBiometrico>();
            RegistroBiometricoNuevo = new RegistroBiometrico();
            HoraEntradaEstablecida = new HorarioLaboral();
            RegistroBiometricoRequest = new RegistroBiometricoRequest();
            NombreRed = "";
        }

        public List<RegistroBiometrico> ListaRegistroBiometrico { get; set; }
        public string NombreRed { get; set; }
        public RegistroBiometrico RegistroBiometricoNuevo { get; set; }
        public HorarioLaboral HoraEntradaEstablecida { get; set; }
        public int AtrasosMes { get; set; }
        public RegistroBiometricoRequest RegistroBiometricoRequest { get; set; }
    }
}
