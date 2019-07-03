using System;
using System.Collections.Generic;
using System.Text;

namespace 随便写写.Demo.Interface
{
    public interface IPasswordHasher
    {
        string HashPassword(string password);
        EnumValidatePasswordResult VerifyHashedPassword(string hashPassword, string providedPassword);
    }
}
