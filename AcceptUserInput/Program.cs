using System;

namespace AcceptUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for their name:
            // Capture the input
            Console.WriteLine("Hello what's your name?");
            string username = Console.ReadLine();

            // Ask the user for the year they were born:
            // Capture the input
            Console.WriteLine("What year were you born?");
            string yearBorn = Console.ReadLine();

            if (int.TryParse(yearBorn, out var userAge))
            {
                var userAgeConverted = DateTime.Now.Year - userAge;

                // Display a message to the user "Hello {user} you were {x} years old."
                Console.WriteLine($"Hello {username} you are {userAgeConverted} years old.");
            }
            else 
            {
                Console.WriteLine($"Hello {username}, I am sorry we can not tell your age.");
            }

        }
    }
}
