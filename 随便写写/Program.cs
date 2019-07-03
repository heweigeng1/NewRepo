using System;
using 随便写写.Demo.Interface;

namespace 随便写写
{
    class Program
    {
        static void Main(string[] args)
        {
            //控制台打印加密后字符串
            PrintHashPassword();
        }

        private static void PrintHashPassword()
        {
            IPasswordHasher passwordHasher = new PasswordHasher();
            while (true)
            {
                Console.WriteLine("please enter password:");
                string password = Console.ReadLine();
                var sha256password = passwordHasher.HashPassword(password);
                Console.WriteLine(sha256password);
            }
        }
    }
}
