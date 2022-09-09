namespace Core.Seguridades.Model.Transaccion.Request.Usuarios
{
    /// <summary>
    /// Solicitud de datos para actualizar usaurio
    /// </summary>
    public class ActualizarUsuarioRequest
    {
        public ActualizarUsuarioRequest() 
        {
        
        }
        public string CodigoHorarioLaboral { get; set; }
        public string CodigoEmpresa { get; set; }
        public string NombreRed { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaSalida { get; set; }
        public string Imagen { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
    }
}
