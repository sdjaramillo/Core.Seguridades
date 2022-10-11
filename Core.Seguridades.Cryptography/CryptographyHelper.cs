using System.Security.Cryptography;
using System.Text;

namespace Core.Seguridades.Cryptography
{
    public static class CryptographyHelper
    {
        /// <summary>
        /// Constante para encriptación de cadenas de texto
        /// </summary>
        private const string Key = $"6cc4914c1dc349bba60fdef75505dd43";

        /// <summary>
        /// Metodo para encriptar Cadenas de Texto
        /// </summary>
        /// <param name="text">Resibe una cadena de texto para encriptar</param>
        /// <returns></returns>
        public static string EncryptString(string text)
        {
            var key = Encoding.UTF8.GetBytes(Key);

            using (var aesAlg = Aes.Create())
            {
                using (var encryptor = aesAlg.CreateEncryptor(key, aesAlg.IV))
                {
                    using (var msEncrypt = new MemoryStream())
                    {
                        using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                        }

                        var iv = aesAlg.IV;
                        var decryptedContent = msEncrypt.ToArray();
                        var result = new byte[iv.Length + decryptedContent.Length];

                        Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                        Buffer.BlockCopy(decryptedContent, 0, result, iv.Length, decryptedContent.Length);

                        return Convert.ToBase64String(result);
                    }
                }
            }
        }

        /// <summary>
        /// Metodo para desencriptar
        /// </summary>
        /// <param name="encryptText">Recibe un texto encriptado para desencriptar</param>
        /// <returns></returns>
        public static string DecryptString(string encryptText)
        {
            var fullCipher = Convert.FromBase64String(encryptText);

            var iv = new byte[16];
            var cipher = new byte[16];

            Buffer.BlockCopy(fullCipher, 0, iv, 0, iv.Length);
            Buffer.BlockCopy(fullCipher, iv.Length, cipher, 0, iv.Length);
            var key = Encoding.UTF8.GetBytes(Key);

            using (var aesAlg = Aes.Create())
            {
                using (var decryptor = aesAlg.CreateDecryptor(key, iv))
                {
                    string result;
                    using (var msDecrypt = new MemoryStream(cipher))
                    {
                        using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                        {
                            using (var srDecrypt = new StreamReader(csDecrypt))
                            {
                                result = srDecrypt.ReadToEnd();
                            }
                        }
                    }
                    return result;
                }
            }
        }
    }
}

