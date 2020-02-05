using FileHelper;
using System;
using System.IO;

namespace FileReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fileContent2 = File.ReadAllText("SimpleText.txt");

            // 1. Read proessMe.csv file
            string[] fileContent = File.ReadAllLines("ProcessMe.csv");

            // 2. iterate through the file result
            for (int i = 0; fileContent.Length > i; i++)
            {
                // 3. skip the header information and read line by line
                if (i == 0)
                {
                    continue;
                }

                // 4. check the price if greater than three thousand then output the data to the console
                string[] line = fileContent[i].Split(',');
                decimal.TryParse(line[3], out decimal intPrice);

                if(intPrice > 3000)
                {
                    Console.WriteLine($"{line[1]} : {line[3]}");
                }
        }
    }
}
