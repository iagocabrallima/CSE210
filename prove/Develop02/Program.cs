using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "What happened today?",
            "What was the best thing that happened today?",
            "What was the worst thing that happened today?",
            "What was the most interesting thing I saw or heard today?",
            "What was the most challenging thing I faced today?",
            "What am I grateful for today?",
            "What did I learn today?",
            "What was the most fun thing I did today?",
            "What was the most surprising thing that happened today?",
            "What did I do today that I am proud of?"
        };
        int answer = -1;
         while (answer != 5)
            {
                Console.WriteLine("\nWelcome to the Journal Program");
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {
                    string prompt = GetRandomPrompt(prompts);
                        journal.AddEntry(prompt);
                        break;
                }

                else if (answer == 2)
                {
                    journal.DisplayEntries();
                        break;
                }

                else if (answer == 3)
                {
                    journal.SaveToFile();
                        break;
                }

                else if (answer == 4)
                {
                    journal.LoadFromFile();
                        break;
                }

                else if (answer == 5)
                {
                    break;
                }

                else if(answer == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("That is not an option");
                        break;
                }
            }

            static string GetRandomPrompt(List<string> prompts)
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}