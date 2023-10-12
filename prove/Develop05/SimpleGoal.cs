
    public class SimpleGoal : Goal
    {
        // Constructors
        public SimpleGoal(string name, string description, int points)
            : base(name, description, points) { }

        public SimpleGoal(
            string name,
            string desc,
            int points,
            int earned,
            int timesCompleted,
            bool isComplete
        )
            : base(name, desc, points, earned, timesCompleted, isComplete) { }

        // Methods
        public override void RecordProgress()
        {
            if (!IsComplete())
            {
                AddEarned(GetPoints());
                IncreaseTimesCompleted();
                MarkComplete();
            }
        }

        public override string ToString()
        {
            return $"[{(IsComplete() ? "X" : " ")}] {GetName()} - {GetDescription()}";
        }

        public override string GetSummary()
        {
            return $"Name: {GetName()}\nDescription: {GetDescription()}\nPoints: {GetPoints()}\nEarned: {GetEarned()}\nComplete: {IsComplete()}";
        }

        public override string SaveString()
        {
            return $"1##{GetName()}##{GetDescription()}##{GetPoints()}##{GetEarned()}##{GetTimesCompleted()}##{IsComplete()}";
        }
    }
