using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class Password
    {
        private string generatedPass;
        public string GeneratePassword(int passSize)
        {
            if (passSize < 0)
                throw new ArgumentException("length must be greater than zero");
            
            
            return generatedPass;

        }
    }
}
