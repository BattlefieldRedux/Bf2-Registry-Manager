using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bf2_Registry_Manager
{
    static class CDkeyGenerator
    {
        /// <summary>
        /// Generetes a random key 
        /// </summary>
        /// <returns>Key string</returns>
        public static string GenerateRandomKey()
        {
            StringBuilder Key = new StringBuilder();
            const int KeyLenght = 24;
            const int space = 4;
            int spaceCount = space;
            const string _char = "0123456789ABCDEFGHJKLMNPQRSTUVWXYZ";
            Random random = new Random();
            for (int count = 1; Key.Length < KeyLenght; count++)
            {
                Key.Append(_char[random.Next(0, _char.Length)]);
                if (spaceCount == count && Key.Length < KeyLenght)
                {
                    Key.Append('-');
                    spaceCount += space;
                }
            }
            return Key.ToString();
        }
    }
}
