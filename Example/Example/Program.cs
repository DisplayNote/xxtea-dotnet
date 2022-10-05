using System;
using System.Diagnostics;
using System.IO;
using Xxtea;

namespace Example
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine($"usage: {Path.GetFileNameWithoutExtension(Environment.GetCommandLineArgs()[0])} <text> <key>");
                Environment.Exit(1);
                return;
            }
            String str = args[0];
            String key = args[1];
            String encrypt_data = XXTEA.EncryptToBase64String(str, key);
            Console.WriteLine(encrypt_data);
        }
    }
}