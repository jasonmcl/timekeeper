using System;
using System.IO;

namespace TimeKeeper.Console
{
    class FileTimeWriter : ITimeWriter
    {
        private string filePath;

        public FileTimeWriter(string folderPath)
        {
            string todaysDate = DateTime.Now.ToString("yyyy-MM-dd");
            FileInfo file = new FileInfo(folderPath);
            file.Directory.Create();
            filePath = folderPath + todaysDate + ".txt";
        }

        public void LogStart()
        {
            System.Console.WriteLine("Time Started: " + DateTime.Now.ToShortTimeString());
            using (var sw = File.AppendText(filePath))
            {
                sw.WriteLine("Time Started: " + DateTime.Now.ToShortTimeString());
            }
        }

        public void LogStop()
        {
            System.Console.WriteLine("Time Stopped: " + DateTime.Now.ToShortTimeString());
            using (var sw = File.AppendText(filePath))
            {
                sw.WriteLine("Time Stopped: " + DateTime.Now.ToShortTimeString());
            }
        }

        public void LogBreakStart()
        {
            System.Console.WriteLine("Break Started: " + DateTime.Now.ToShortTimeString());
            using (var sw = File.AppendText(filePath))
            {
                sw.WriteLine("Break Started: " + DateTime.Now.ToShortTimeString());
            }
        }

        public void LogBreakStop()
        {
            System.Console.WriteLine("Break Stopped: " + DateTime.Now.ToShortTimeString());
            using (var sw = File.AppendText(filePath))
            {
                sw.WriteLine("Break Stopped: " + DateTime.Now.ToShortTimeString());
            }
        }
    }
}
