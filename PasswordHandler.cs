using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HLock
{
    public static class PasswordHandler
    {
        private static readonly string Path = "data.txt";

        private static bool forceNoSave = false;

        public static string MasterPassword { get; private set; }

        public static readonly Dictionary<string, string> Passwords = new Dictionary<string, string>();

        public static void Initialize(string masterPassword)
        {
            MasterPassword = masterPassword;

            Load();
        }

        public static void Load()
        {
            if (!File.Exists(Path))
            {
                var file = File.Create(Path);
                file.Close();
                file.Dispose();
            }

            var lines = File.ReadAllLines(Path);

            for(int i = 0; i < lines.Length; i++)
            {
                var data = lines[i].Split(':');

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
                    forceNoSave = true;
                    Application.Exit();
                }
            }
        }

        public static void Save()
        {
            if (forceNoSave)
                return;

            var lines = new string[Passwords.Count];

            for(int i = 0; i < lines.Length; i++)
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
        }

        public static void RemovePassword(string tag)
        {
            Passwords.Remove(tag);
        }
    }
}
