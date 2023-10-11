using System;

// To exceed the requirements, I created a special loading animation.

class Program
{
    static void Main(string[] args)
    {
        bool runProgram = true;
        while (runProgram)
        {
            Console.Clear();
            Console.Write("Welcome to your mindfulness coach!\n\n");
            Console.Write("What activity would you like to do today?\n\n");
            Console.Write(
                "1. Breathing Activity\n2. Reflecting Activity\n3. Listing Activity\n4. Quit\n\n> "
            );
            string activityType = Console.ReadLine();

            Activity funTimesWithTyler;
            switch (activityType)
            {
                case "1":
                {
                    funTimesWithTyler = new BreathingActivity();
                    break;
                }
                case "2":
                {
                    funTimesWithTyler = new ReflectingActivity();
                    break;
                }
                case "3":
                {
                    funTimesWithTyler = new ListingActivity();
                    break;
                }
                case "4":
                {
                    runProgram = false;
                    funTimesWithTyler = new Activity("none", "problem");
                    break;
                }
                default:
                {
                    funTimesWithTyler = new Activity("none", "problem");
                    break;
                }
            }

            funTimesWithTyler.Execute();
        }
    }
}