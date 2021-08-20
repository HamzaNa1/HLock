using System;

namespace HLock.Password
{
    public static class PasswordGenerator
    {
        private const string LettersLower = "qwertyuiopasdfghjklzxcvbnm";
        private const string LettersUpper = "QWERTYUIOPASDFGHJKLZXCVBNM";

        private const string Numbers = "1234567890";
        private const string SpecialCharacters = "!@#$%^&*";

        private static readonly Random Random = new();

        public static string Generate(int amount, bool useUpper = false, bool useNumbers = false, bool useSpecialCharacters = false)
        {
            var password = "";

            var usable = LettersLower;

            if (useUpper)
                usable += LettersUpper;
            if (useNumbers)
                usable += Numbers;
            if (useSpecialCharacters)
                usable += SpecialCharacters;

            for(var i = 0; i < amount; i++)
            {
                password += usable[Random.Next(0, usable.Length)];
            }

            return password;
        }
    }
}
