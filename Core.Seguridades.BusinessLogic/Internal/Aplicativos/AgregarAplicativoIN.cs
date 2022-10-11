using Core.Common.ProcessTemplate.InternalBusinessLogic;
using Core.Seguridades.BusinessLogic.Ejecucion.Aplicativos;
using Core.Seguridades.Model.Transaccion.Response.Aplicativos;
using Core.Seguridades.Model.Transaccion.Transaccional.Aplicativos;


namespace Core.Seguridades.BusinessLogic.Internal.Aplicativos
{
    public class AgregarAplicativoIN : IInsertar<AplicativosTrx, AgregarAplicativoResponse>
    {
        public void AgregarInformacion(AplicativosTrx objetoTransaccional)
        {
            
        }

        public void HomologarInformacion(AplicativosTrx objetoTransaccional)
        {
            
        }

        public void InsertarInformacion(AplicativosTrx objetoTransaccional)
        {
            AgregarAplicativoBLL.AgregarAplicativo(objetoTransaccional);
        }

        public void ValidarInformacion(AplicativosTrx objetoTransaccional)
        {
            ValidarDatosAplicativoBLL.ValidarCamposVaciosAplicativoRequest(objetoTransaccional);
        }
    }
}
