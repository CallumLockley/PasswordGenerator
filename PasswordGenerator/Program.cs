using System;

namespace PasswordGenerator
{
    public class Program
    {
        public static int passSize;
        public static string genPass;
        
        static void Main(string[] args)
        {
            Console.WriteLine("How many characters does the password need?");
            passSize = Convert.ToInt32(Console.ReadLine());

            genPass  = Password.GeneratePassword(passSize);

            Console.WriteLine(genPass.ToString());
        }




    }
}
