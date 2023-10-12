
    // Define class
    public class CreateChecklistGoalCommand : Command
    {
        // Constructors
        public CreateChecklistGoalCommand(Repository repo)
            : base(repo) { }

        // Methods
        public override void Execute()
        {
            Console.Write("Name of goal: ");
            string name = Console.ReadLine();
            Console.Write("Description of goal: ");
            string description = Console.ReadLine();
            Console.Write("Point value: ");
            int points = int.Parse(Console.ReadLine());
            Console.Write("Times to complete: ");
            int timesToComplete = int.Parse(Console.ReadLine());
            Console.Write("Completion Bonus: ");
            int completionBonus = int.Parse(Console.ReadLine());
            Goal goal = new ChecklistGoal(
                name,
                description,
                points,
                timesToComplete,
                completionBonus
            );
            _repository.Add(goal);
            // return goal;
        }
    }
