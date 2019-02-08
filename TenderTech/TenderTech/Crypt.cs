using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TenderTech
{
    public class Crypt
    {
        /// <summary>Метод, с помощью которого вы шифруете данные.</summary>
        /// <param name="text">Текст, который вы хохите зашифровать.</param>
        /// <returns>Возвращает зашифрованный текст строкового типа</returns>
        public string Encrypt(string text)
        {
            Rijndael rjndl = Rijndael.Create();
            string result = "";
            byte[] key = { 182, 21, 29, 2, 34, 135, 196, 181, 1, 239, 247, 157, 150, 26, 128, 110, 13, 198, 178, 42, 236,
                           22, 3, 190, 114, 131, 13, 10, 54, 201, 68, 54 };
            byte[] IV = { 242, 102, 223, 215, 42, 224, 134, 66, 41, 159, 231, 52, 49, 34, 27, 47 };

            rjndl.Key = key;
            rjndl.IV = IV;
            rjndl.Padding = PaddingMode.PKCS7;
            rjndl.Mode = CipherMode.CBC;

            var encryptor = rjndl.CreateEncryptor(rjndl.Key, rjndl.IV);
            byte[] textinbytes = Encoding.UTF8.GetBytes(text);

            using (MemoryStream msEncrypt = new MemoryStream())
            {
                using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                {
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(text);
                    }
                }
                result = Convert.ToBase64String(msEncrypt.ToArray());
            }
            return result;
        }

        /// <summary>Метод, с помощью которого вы расшифровываете данные.</summary>
        /// <param name="text">Тест, который вы хотите расшифровать.</param>
        /// <returns>Возвращает расшифрованный текст строкового типа</returns>
        public string Decrypt(string text)
        {
            Rijndael rjndl = Rijndael.Create();
            byte[] key = { 182, 21, 29, 2, 34, 135, 196, 181, 1, 239, 247, 157, 150, 26, 128, 110, 13, 198, 178, 42, 236,
                           22, 3, 190, 114, 131, 13, 10, 54, 201, 68, 54 };
            byte[] IV = { 242, 102, 223, 215, 42, 224, 134, 66, 41, 159, 231, 52, 49, 34, 27, 47 };

            rjndl.Key = key;
            rjndl.IV = IV;
            rjndl.Padding = PaddingMode.PKCS7;
            rjndl.Mode = CipherMode.CBC;

            var decryptor = rjndl.CreateDecryptor(rjndl.Key, rjndl.IV);
            var textinbytes = Convert.FromBase64String(text);

            using (MemoryStream msDecrypt = new MemoryStream(textinbytes))
            {
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                {
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        text = srDecrypt.ReadToEnd();
                    }
                }
            }
            return text;
        }
    }
}
