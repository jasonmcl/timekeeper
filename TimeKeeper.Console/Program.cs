using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TimeKeeper.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World");
            string folderPath = @"./times/";
            var todaysDate = DateTime.Now.ToString("yyyy-MM-dd");
            string filePath = folderPath + todaysDate + ".txt";

            FileInfo file = new FileInfo(folderPath);
            file.Directory.Create();

            using (var sw = File.AppendText(filePath))
            {
                sw.WriteLine("Test");
            }

            System.Console.WriteLine("Done");
            System.Console.Read();
        }
    }
}
