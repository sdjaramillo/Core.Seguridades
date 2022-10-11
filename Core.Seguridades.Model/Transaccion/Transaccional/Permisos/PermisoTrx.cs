using Core.Common.Model.Transaccion;
using Core.Seguridades.Model.Entidad.Permisos;
using Core.Seguridades.Model.Transaccion.Request.Permisos;


namespace Core.Seguridades.Model.Transaccion.Transaccional.Permisos
{
    public class PermisoTrx : TransaccionBase
    {
        public PermisoTrx()
        {
            ListaPermisos = new List<Permiso>();
            ListaPermisosObtener = new List<PermisoDatosGraficos>();
            PermisoRequest = new PermisoRequest();
            PermisoCodigo = "";
            ProyectoCodigo = "";
            PermisoValido = new Permiso();
        }
        public List<Permiso> ListaPermisos { get; set; }
        public List<PermisoDatosGraficos> ListaPermisosObtener { get; set; }
        public string PermisoCodigo { get; set; }
        public string ProyectoCodigo { get; set; }
        public PermisoRequest PermisoRequest { get; set; }
        public Permiso PermisoValido { get; set; }
    }
}
