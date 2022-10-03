namespace Core.Seguridades.Model.Transaccion.Request.RegistrosBiometrico
{
    public class RegistroBiometricoRequest
    {
        public RegistroBiometricoRequest() {}
        public string EstadoAnimoCodigo { get; set; }
        public string NombreRed { get; set; }
        public string Codigo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string HoraEntrada { get; set; }
        public string HoraSalida { get; set; }
        public string IpRegistro { get; set; }
        public string PcNombre { get; set; }
        public string HoraInicioAlmuerzo { get; set; }
        public string HoraFinAlmuerzo { get; set; }
        public float TiempoAtraso { get; set; }
        public string Descripcion { get; set; }
    }

}
