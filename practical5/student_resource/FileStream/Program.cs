using System;
using System.IO;
namespace FileStream
{
    class Program
    {
        public static void Main()
        {
            string path = @"MyTest.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello World");
                }
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            if (path = "abc") {
                Console.WriteLine("This is very hard to detect");
            }
        }
    }
}
