using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher_Radianta_Novo
{
    internal class CsenhasRandom

    {   
        private static readonly Random random = new Random();

        public static string GeneratePassword(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%&Çç()";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }


    
    }
}
