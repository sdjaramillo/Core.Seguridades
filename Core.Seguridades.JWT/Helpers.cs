using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Seguridades.Helpers
{
    public static partial class Helpers
    {
        private const string Key = "6cc4914c1dc349bba60fdef75505dd43";
        public static string Encriptar(this string cadena)
        {
            byte[] arreglo = UTF8Encoding.UTF8.GetBytes(cadena);
            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Key));
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;

            ICryptoTransform convertir = tripledes.CreateEncryptor();
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length);
            tripledes.Clear();

            return Convert.ToBase64String(resultado, 0, resultado.Length);
        }

        public static string DesEncriptar(this string cadena)
        {
            byte[] arreglo = Convert.FromBase64String(cadena);
            MD5 md5 = MD5.Create();
            TripleDES tripledes = TripleDES.Create();

            tripledes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(Key));
            tripledes.Mode = CipherMode.ECB;
            tripledes.Padding = PaddingMode.PKCS7;
            ICryptoTransform convertir = tripledes.CreateDecryptor();
            byte[] resultado = convertir.TransformFinalBlock(arreglo, 0, arreglo.Length);
            tripledes.Clear();

            return UTF8Encoding.UTF8.GetString(resultado);
        }
    }
}
