using System;
using Develop03.Classes;

class Program
{
    static void Main(string[] args)
    {
        string scriptureString =
            "Ether 12:27 - And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        Scripture toMemorize = new Scripture(scriptureString);
        toMemorize.DisplayScripture();
        Console.WriteLine("Hit <enter> to hide more words. Type 'quit'<enter> to exit.");
        bool allDone = false;
        while (!allDone)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            allDone = toMemorize.HideRandomWords(5);
            toMemorize.DisplayScripture();
        }
    }
}