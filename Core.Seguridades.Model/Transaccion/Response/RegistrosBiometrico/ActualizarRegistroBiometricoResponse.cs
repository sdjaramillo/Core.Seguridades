using Core.Seguridades.Model.Transaccion.Request.RegistrosBiometrico;

namespace Core.Seguridades.Model.Transaccion.Response.RegistrosBiometrico
{
    public class ActualizarRegistroBiometricoResponse
    {
        public ActualizarRegistroBiometricoResponse() 
        {
            RegistroBiometricoActualizado = new ActualizarRegistroBiometricoRequest();
        }
        public ActualizarRegistroBiometricoRequest RegistroBiometricoActualizado { get; set; }
    }
}
