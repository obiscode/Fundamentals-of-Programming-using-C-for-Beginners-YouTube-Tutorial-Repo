using System;
using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string writeText = "Hello, I created this file with c#";
            File.WriteAllText("filename.txt", writeText);

            string readText = File.ReadAllText("filename.txt");

            Console.WriteLine(readText);
        }
    }
}
