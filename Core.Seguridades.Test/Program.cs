using Core.Seguridades.Helpers;

string clave = "Maresa123";
string encriptado = string.Empty;
string deencriptado = string.Empty;

 encriptado = Helpers.Encriptar(clave);
deencriptado = Helpers.DesEncriptar(encriptado);

var x = 1;
//encriptado encriptado