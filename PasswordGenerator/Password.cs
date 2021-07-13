using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class Password
    {
        public static string GeneratePassword(int passSize)
        {

            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ.<+|&!*-%>?:=";

            if (passSize < 0)
            {
                Console.WriteLine("Your password length must be greater than zero");
                throw new ArgumentException("length must be greater than zero");

            }

            var password = new char[passSize];
            var rd = new Random();

            for (var i = 0; i < passSize; i++)
            {
                password[i] = chars[rd.Next(0, chars.Length)];
            }

            return new String(password);
        }
    }
}
