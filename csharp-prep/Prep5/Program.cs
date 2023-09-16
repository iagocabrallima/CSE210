using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();

        string userName = Name();
        int userNumber = Number();

        int squaredNumber = SquareNumber(userNumber);

        Result(userName, squaredNumber);
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string Name()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int Number()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void Result(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}