using System;

namespace PasswordGenerator
{
    class Program
    {
        public static int passSize;
        public string genPass;
        
        static void Main(string[] args)
        {
            Console.WriteLine("How many characters does the password need?");
            passSize = Convert.ToInt32(Console.ReadLine());
        }



        
    }
}
