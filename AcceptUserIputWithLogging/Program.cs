using System;
using System.IO;

namespace AcceptUserIputWithLogging
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. provding some info for the user "What is your name?"
            // 2. ask user what year they were born.
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What year were you born?");
            string usersBirthDate = Console.ReadLine();
            int number1;
            bool results = int.TryParse(usersBirthDate, out number1);

            if (results)
            {
                int currentYear = DateTime.Today.Year;
                int yearsOld = currentYear - number1;

                // 3. out put user name with age
                Console.WriteLine("Thank you " + userName + "! You are " + yearsOld + " years old.");
            }
            else
            {
                Console.WriteLine("Thank you " + userName + "! I am sorry I can't tell your age.");
                File.AppendAllText("log.txt", DateTime.Now + ": " + userName + ": " + usersBirthDate + Environment.NewLine);
            }
        }
    }
}
