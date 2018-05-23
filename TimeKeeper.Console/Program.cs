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
            //System.Console.WriteLine("Hello World");
            //string folderPath = @"./times/";
            //var todaysDate = DateTime.Now.ToString("yyyy-MM-dd");
            //string filePath = folderPath + todaysDate + ".txt";

            //FileInfo file = new FileInfo(folderPath);
            //file.Directory.Create();

            //using (var sw = File.AppendText(filePath))
            //{
            //    sw.WriteLine("Test");
            //}

            string input;
            do
            {
                input = System.Console.ReadLine();
                PerformAction(input);
                
            } while (input.ToLower() != "end");

            System.Console.WriteLine("Done");
            System.Console.Read();
        }

        private static void PerformAction(string input)
        {
            switch (input.ToLower())
            {
                case "start": StartClock();
                    break;
                case "end": StopClock();
                    break;
                case "break-start": StartBreak();
                    break;
                case "break-end": StopBreak();
                    break;
                case "help": Help();
                    break;
                default: DefaultAction(input);
                    break;
            }
        }

        private static void DefaultAction(string input)
        {
            System.Console.WriteLine("Invalid Command Entered: \"" + input + "\" for help type \"help\"");
        }

        private static void StartClock()
        {
            System.Console.WriteLine("Starting Clock: " + DateTime.Now.ToShortTimeString());
        }

        private static void StopClock()
        {
            System.Console.WriteLine("Stopping Clock: " + DateTime.Now.ToShortTimeString());
        }

        private static void StartBreak()
        {
            System.Console.WriteLine("Starting Break: " + DateTime.Now.ToShortTimeString());
        }

        private static void StopBreak()
        {
            System.Console.WriteLine("Stopping Break: " + DateTime.Now.ToShortTimeString());
        }

        private static void Help()
        {
            System.Console.WriteLine("Valid Commands: ");
            System.Console.WriteLine("     start");
            System.Console.WriteLine("     end");
            System.Console.WriteLine("     break-start");
            System.Console.WriteLine("     break-end");
            System.Console.WriteLine("     help");
        }
    }
}
