using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers = new List<int>();
        int number= -1;
        int sum = 0;
        while(number != 0)
       {
            Console.WriteLine("Enter number (0 to quit): ");
            number = int.Parse(Console.ReadLine());
        
            if(number != 0)
            {
                numbers.Add(number);
            }
        }
        
        foreach (int n in numbers)
        {
            sum += n;
        }
        
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is : {average}");

        int max = numbers[0];

        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }
        Console.WriteLine($"The max is: {max}");
}
}
