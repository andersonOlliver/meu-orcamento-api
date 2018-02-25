using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Meu.Orcamento.CrossCuting.Criptografia
{
    public class CriptografiaCrossCuting
    {

        public static string GeraRandom(int length = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();

            var result = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return result;

        }

        public static string GeraHashSHA256(string value)
        {
            using (SHA256 hash = SHA256Managed.Create())
            {
                return value = String.Concat(hash
                    .ComputeHash(Encoding.UTF8.GetBytes(value))
                    .Select(item => item.ToString("x2")));
            }
        }
    }
}
