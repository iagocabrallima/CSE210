
    public class ChecklistGoal : Goal
    {
        // Attributes
        private int _timesToComplete;
        private int _completionBonus;

        // Constructors
        public ChecklistGoal(
            string name,
            string description,
            int points,
            int timesToComplete,
            int completionBonus
        )
            : base(name, description, points)
        {
            _timesToComplete = timesToComplete;
            _completionBonus = completionBonus;
        }

        public ChecklistGoal(
            string name,
            string desc,
            int points,
            int earned,
            int timesCompleted,
            bool isComplete,
            int timesToComplete,
            int completionBonus
        )
            : base(name, desc, points, earned, timesCompleted, isComplete)
        {
            _timesToComplete = timesToComplete;
            _completionBonus = completionBonus;
        }

        // Methods
        public override void RecordProgress()
        {
            if (!IsComplete())
            {
                AddEarned(GetPoints());
                IncreaseTimesCompleted();
                if (GetTimesCompleted() == _timesToComplete)
                {
                    AddEarned(_completionBonus);
                    MarkComplete();
                }
            }
        }

        public override string ToString()
        {
            return $"[{GetTimesCompleted()}/{_timesToComplete}] {GetName()} - {GetDescription()}";
        }

        public override string GetSummary()
        {
            return $"Name: {GetName()}\nDescription: {GetDescription()}\nPoints: {GetPoints()}\nEarned: {GetEarned()}\nTimes Completed: {GetTimesCompleted()}\nTimes To Complete: {_timesToComplete}\nCompletion Bonus: {_completionBonus}";
        }

        public override string SaveString()
        {
            return $"3##{GetName()}##{GetDescription()}##{GetPoints()}##{GetEarned()}##{GetTimesCompleted()}##{IsComplete()}##{_timesToComplete}##{_completionBonus}";
        }
    }