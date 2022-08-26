namespace Core.Seguridades.Model.Entidad.Usuarios
{
    /// <summary>
    /// Modelo de la tabla de usuario SEG_USUARIO
    /// </summary>
    public class Usuario
    {
        public Usuario()
        {
        }

        public int UsuarioId { get; set; }
        public string CodigoHorarioLaboral { get; set; }
        public string CodigoRol { get; set; }
        public string CodigoEmpresa { get; set; }
        public string NombreRedUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public DateTime FechaNacimientoUsuario { get; set; }
        public DateTime FechaIngresoUsuario { get; set; }
        public DateTime FechaSalidaUsuario { get; set; }
        public byte[] ImagenUsuario { get; set; }
        public string CorreoElectronicoUsuario { get; set; }
        public bool EstadoUsuario { get; set; }
        public string DescripcionUsuario { get; set; }
    }
}
