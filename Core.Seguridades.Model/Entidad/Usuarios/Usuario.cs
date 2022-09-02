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

        public int Id { get; set; }
        public string CodigoHorarioLaboral { get; set; }
        public string CodigoRol { get; set; }
        public string CodigoEmpresa { get; set; }
        public string NombreRed { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaSalida { get; set; }
        public string Imagen { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Estado { get; set; }
        public string Descripcion { get; set; }
    }
}
