using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileNamesInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            String inputPath = "C:\\";
            string[] files = Directory.GetFiles(inputPath);
            Console.Write(files.Length);
            for (int index = 0; index < files.Length; index++) {
                Console.WriteLine("File: "+files[index]);
                Console.WriteLine("File Name: " + Path.GetFileName(files[index]));
            }
                Console.Read();

            
        }
    }
}
