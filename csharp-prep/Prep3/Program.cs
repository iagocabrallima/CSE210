using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        

        string response = "";
        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(0,100);
            int guess = -1;
            int count = 0;

            while(guess != number)
            {
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }

                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it");
                    Console.WriteLine($"You tried {count} times");
                    Console.WriteLine("Do you want to play again?");
                    response = Console.ReadLine();
                }
                count ++;
            }
        }
        while(response == "yes");
    }
}
