namespace Core.Seguridades.Model.Transaccion.Request.MenuDinamico
{
    public class EliminarPermisoMenuRequest
    {
        public EliminarPermisoMenuRequest() { }

        public string MenuCodigo { get; set; }
        public string RolCodigo { get; set; }
        public string OpcionMenu { get; set; }
    }
}
