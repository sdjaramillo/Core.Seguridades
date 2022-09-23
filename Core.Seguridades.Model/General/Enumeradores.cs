namespace Core.Seguridades.Model.General
{
    public enum Error
    {
        OperacionExitosa = 10000,
    }


    public enum ErrorUsuario { 
    
        NoExisteNombreEmpresaAsignada = 20001,
        NoExisteUsuariosBaseDatos = 20002,
        CamposVaciosAutenticacionActiveDirectory = 20003,
        CredencialesIncorrectasActiveDirectory = 20004,

    }

    public enum ErrorImagen
    {

        NoExisteNombreEmpresaAsignada = 20011,
        CamposVaciosImagenRequest = 20012,
        NoExisteImagenBaseDatos = 20013,

    }

    public enum ErrorNoticia
    {
        NoExistePermisoPublicacion = 20021,
        NoExisteNoticiaBaseDatos = 20022,
        CamposVaciosNoticaRequest = 20023,
    }

    public enum ErrorBiometrico
    {
        NoExisteRegistroBiometricoDia = 20031,
    }

    public enum ErrorAplicativo
    {
        CamposVaciosAplicativoRequest = 20041,
        NoExisteAplicativoBaseDatos = 20042,
    }
}
