namespace Core.Seguridades.Model.General
{
    public enum Error
    {
        OperacionExitosa = 10000,
    }
  
    public enum ErrorUsuario
    {
        NoExisteNombreEmpresaAsignada = 20001,
        NoExisteUsuariosBaseDatos = 20002,
        CamposVaciosActenticacionActiveDirectory = 20003,
    }

    public enum ErrorCredencialesAcceso
    {
        EntidadNoEncontrada = 30001,
        UsuarioClaveIncorrecto = 30002
    }

}
