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
            if (passSize < 0)
            {
                Console.WriteLine("Your password length must be greater than zero");
                throw new ArgumentException("length must be greater than zero");

            }
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < passSize; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();

        }
    }
}
