
    // Define class
    public class CreateEternalGoalCommand : Command
    {
        // Constructors
        public CreateEternalGoalCommand(Repository repo)
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
            Goal goal = new EternalGoal(name, description, points);
            _repository.Add(goal);
            // return goal;
        }
    }
