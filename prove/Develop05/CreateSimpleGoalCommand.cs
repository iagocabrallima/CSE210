
    // Define class
    public class CreateSimpleGoalCommand : Command
    {
        // Constructors
        public CreateSimpleGoalCommand(Repository repo)
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
            Goal goal = new SimpleGoal(name, description, points);
            _repository.Add(goal);
            // return goal;
        }
    }
