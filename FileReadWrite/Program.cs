using FileHelper;
using System;
using System.IO;

namespace FileReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileContent = File.ReadAllText("SimpleText.txt");

            // 1. read csv file line by line
            string[] fileContent = File.ReadAllLines("ProcessMe.csv");

            // 2. search for model get the value
            for (int i = 0; i < fileContent.Length; i++)
            {
                string line = fileContent[i];

                if (line.Contains("Ford"))
                {
                    // 3. output the price
                    string[] columns = line.Split(',');

                    File.AppendAllText("processedFile.txt", columns[1] + ": " + columns[3]);
                    //Console.WriteLine(columns[3]);
                }
            }

            //Console.WriteLine(fileContent);
        }
    }
}
