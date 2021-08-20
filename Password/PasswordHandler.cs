using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using HLock.Cipher;

namespace HLock.Password
{
    public static class PasswordHandler
    {
        private static readonly string Path = "data.txt";

        private static bool _forceNoSave;

        private static string MasterPassword { get; set; }

        public static readonly Dictionary<string, string> Passwords = new();

        public static void Initialize(string masterPassword)
        {
            MasterPassword = masterPassword;

            Load();
        }

        private static void Load()
        {
            if (!File.Exists(Path))
            {
                var file = File.Create(Path);
                file.Close();
                file.Dispose();
            }

            var lines = File.ReadAllLines(Path);

            foreach (var line in lines)
            {
                var data = line.Split(':');

                if (data.Length != 2)
                    continue;

                try
                {
                    var tag = StringCipher.Decrypt(data[0], MasterPassword);
                    var password = StringCipher.Decrypt(data[1], MasterPassword);

                    Passwords.Add(tag, password);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Password is wrong.");
                    _forceNoSave = true;
                    Application.Exit();
                }
            }
        }

        private static void Save()
        {
            if (_forceNoSave)
                return;

            var lines = new string[Passwords.Count];

            for(var i = 0; i < lines.Length; i++)
            {
                var tag = Passwords.Keys.ElementAt(i);
                var cipheredTag = StringCipher.Encrypt(tag, MasterPassword);
                var password = StringCipher.Encrypt(Passwords[tag], MasterPassword);

                lines[i] = $"{cipheredTag}:{password}";
            }

            File.WriteAllLines(Path, lines);
        }

        public static void AddPassword(string tag, string password)
        {
            Passwords.Add(tag, password);
            Save();
        }

        public static void RemovePassword(string tag)
        {
            Passwords.Remove(tag);
            Save();
        }
    }
}
