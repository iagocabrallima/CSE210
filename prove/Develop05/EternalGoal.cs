
    public class EternalGoal : Goal
    {
        // Constructors
        public EternalGoal(string name, string description, int points)
            : base(name, description, points) { }

        public EternalGoal(
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
            AddEarned(GetPoints());
            IncreaseTimesCompleted();
        }

        public override string ToString()
        {
            return $"[{GetTimesCompleted()}x] {GetName()} - {GetDescription()}";
        }

        public override string GetSummary()
        {
            return $"Name: {GetName()}\nDescription: {GetDescription()}\nPoints: {GetPoints()}\nEarned: {GetEarned()}\nTimes Completed: {GetTimesCompleted()}";
        }

        public override string SaveString()
        {
            return $"2##{GetName()}##{GetDescription()}##{GetPoints()}##{GetEarned()}##{GetTimesCompleted()}##{IsComplete()}";
        }
    }

