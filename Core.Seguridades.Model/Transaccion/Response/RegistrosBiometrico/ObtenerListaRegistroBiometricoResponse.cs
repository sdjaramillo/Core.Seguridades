
using Core.Seguridades.Model.Entidad.RegistroBiometrico;

namespace Core.Seguridades.Model.Transaccion.Response.RegistrosBiometrico
{
    public class ObtenerListaRegistroBiometricoResponse
    {
        public ObtenerListaRegistroBiometricoResponse()
        {
            RegistroBiometricos = new List<RegistroBiometrico>();
        }
        public List<RegistroBiometrico> RegistroBiometricos { get; set; }
    }
}
