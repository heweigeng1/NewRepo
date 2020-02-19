using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace 随便写写.Demo.Interface
{
    public class PasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            byte[] passwordbyte = Encoding.UTF8.GetBytes(password + "jiami");
            var sha = new SHA256Managed().ComputeHash(passwordbyte);
            return Convert.ToBase64String(sha);
        }

        public EnumValidatePasswordResult VerifyHashedPassword(string hashPassword, string providedPassword)
        {
            return hashPassword == providedPassword ? EnumValidatePasswordResult.Success : EnumValidatePasswordResult.Failed;
        }

    }
}
