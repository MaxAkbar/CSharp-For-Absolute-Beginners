using System;
using System.IO;

namespace FileHelper
{
    public class MyFileHelper
    {
        public static string[] OpenFile(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        public static void AppendToFile(string filePath, string content)
        {
            File.AppendAllText(filePath, content);
        }
    }
}
