using System;
using Foundation3.Classes;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Command> commands = new Dictionary<string, Command>();
        commands["1"] = new CreateLectureCommand();
        commands["2"] = new CreateReceptionCommand();
        commands["3"] = new CreateOutdoorCommand();

        foreach (Command command in commands.Values.ToList())
        {
            command.Execute();
        }
    }
}