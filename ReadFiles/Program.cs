using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ReadFiles
{
    class Program
    {
        public static object JsonObject { get; private set; }

        static void Main(string[] args)
        {

            WriteFile();
            ReadFile();
            Console.WriteLine("Write to the file");
        }


        public static void ReadFile()
        {
            Account account = new Account();
            string readFile = @"C:\\Users\Mak\Desktop\wTest.txt";

            StreamReader sr = new StreamReader(readFile);
            string line = sr.ReadToEnd();

                Console.WriteLine(line);

        }

        public static void WriteFile()
        {
            Account account = new Account
            {
                Email = "mak.ibrahim@gmail.com",
                Active = true,
                CreateDate = new DateTime(2018, 1, 9),
                Roles = new List<string>
                {
                    "User: ilogin",
                    "Admin: true",
                    "Guest: false",
                    "Share: no"
                }

            };

            string json = JsonConvert.SerializeObject(account, Formatting.Indented);

            string fw = @"C:\\Users\Mak\Desktop\wTest.txt";

            StreamWriter writer = new StreamWriter(fw);
            try
            {
                writer.WriteLine(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message, "Erro Writing to the file");
            }

            writer.Close();
        }
    }
}
