using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string InputScore = Console.ReadLine();
        int score = int.Parse(InputScore);
        string letter = ("");

        if (score >= 90)
        {
            letter = ("A");
        }

        else if (score<90 && score >=80)
        {
            letter = ("B");
        }

        else if (score<80 && score>=70)
        {
            letter = ("C");
        }

        else if (score<70 && score>=60)
        {
            letter = ("D");
        }

        else
        {
            letter = ("F");
        }

        Console.WriteLine(letter);

        if (score >= 70)
        {
            Console.WriteLine("Congratulations you passed in this course, you did very well.");
        }
        else
        {
            Console.WriteLine("It wasn't that time but don't be sad you can try again, the secret its to not give up");
        }
    }
}