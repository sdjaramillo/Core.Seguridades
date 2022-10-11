using Core.Seguridades.DataAccess.Usuarios;
using Core.Seguridades.Model.Transaccion.Transaccional.Usuarios;

namespace Core.Seguridades.BusinessLogic.Ejecucion.Usuarios
{
    public static class ObtenerCumpleanieroDiaBLL
    {
        public static void ObtenerCumpleaniero(UsuarioTrx objetoTransaccional)
        {
            ObtenerCumpleanieroDiaDAL.Execute(objetoTransaccional);
        }
    }
}
