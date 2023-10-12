using System;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Command> commands = new Dictionary<string, Command>();
        Repository repo = new Repository();
        commands["1"] = new CreateSimpleGoalCommand(repo);
        commands["2"] = new CreateEternalGoalCommand(repo);
        commands["3"] = new CreateChecklistGoalCommand(repo);

        string foo = "";
        while (foo != "6")
        {
            Console.Clear();
            Console.Write(
                "MAIN MENU\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\n> "
            );
            foo = Console.ReadLine();

            switch (foo)
            {
                case "1":
                {
                    string bar = "";
                    while (bar != "4")
                    {
                        Console.Clear();
                        Console.Write(
                            "CREATE GOAL\n1. Create Simple Goal\n2. Create Eternal Goal\n3. Create Checklist Goal\n4. Back\n> "
                        );
                        bar = Console.ReadLine();
                        if (bar != "4")
                        {
                            Command command = commands[bar];
                            command.Execute();
                        }
                    }
                    break;
                }
                case "2":
                {
                    repo.ListGoals();
                    break;
                }
                case "3":
                {
                    repo.Save();
                    break;
                }
                case "4":
                {
                    repo.Load();
                    break;
                }
                case "5":
                {
                    repo.RecordGoalProgress();
                    break;
                }
                case "6":
                {
                    Console.WriteLine("Program ended successfully.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Please input a number from 1 to 6.");
                    break;
                }
            }
        }

    }
}