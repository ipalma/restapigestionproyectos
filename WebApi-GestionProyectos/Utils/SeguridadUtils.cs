using System;
using System.Security.Cryptography;
using System.Text;

namespace WebApi_GestionProyectos.Utils
{
    public class SeguridadUtils
    {
        public static String Sha1Hash(String pwd)
        {
            var sha = SHA1Managed.Create();
            var encoding = new ASCIIEncoding();
            byte[] datos = sha.ComputeHash(encoding.GetBytes(pwd));
            var bld = new StringBuilder();

            for (int i = 0; i < datos.Length; i++)
            {
                bld.AppendFormat("{0:x2}", datos[i]);
            }
            return bld.ToString();
        }

    }
}