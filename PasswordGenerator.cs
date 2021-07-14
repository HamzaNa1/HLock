using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HLock
{
    public static class PasswordGenerator
    {
        private static readonly string lettersLower = "qwertyuiopasdfghjklzxcvbnm";
        private static readonly string lettersUpper = lettersLower.ToUpper();

        private static readonly string numbers = "1234567890";
        private static readonly string specialCharacters = "!@#$%^&*";

        private static readonly Random random = new Random();

        public static string Generate(int amount, bool useUpper = false, bool useNumbers = false, bool useSpecialCharacters = false)
        {
            string password = "";

            string usable = lettersLower;

            if (useUpper)
                usable += lettersUpper;
            if (useNumbers)
                usable += numbers;
            if (useSpecialCharacters)
                usable += specialCharacters;

            for(int i = 0; i < amount; i++)
            {
                password += usable[random.Next(0, usable.Length)];
            }

            return password;
        }
    }
}
