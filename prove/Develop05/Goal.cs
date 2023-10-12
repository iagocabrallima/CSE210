
    // Define class
    public class Goal
    {
        // Attributes
        private string _name;
        private string _description;
        private int _points;
        protected int _earned = 0;
        protected int _timesCompleted = 0;
        private bool _complete = false;

        // Constructors
        public Goal(string name, string desc, int points)
        {
            _name = name;
            _description = desc;
            _points = points;
        }

        public Goal(
            string name,
            string desc,
            int points,
            int earned,
            int timesCompleted,
            bool isComplete
        )
        {
            _name = name;
            _description = desc;
            _points = points;
            _earned = earned;
            _timesCompleted = timesCompleted;
            _complete = isComplete;
        }

        // Getters & Setters
        protected string GetName()
        {
            return _name;
        }

        protected string GetDescription()
        {
            return _description;
        }

        protected int GetPoints()
        {
            return _points;
        }

        public int GetEarned()
        {
            return _earned;
        }

        protected void AddEarned(int points)
        {
            _earned += points;
        }

        protected int GetTimesCompleted()
        {
            return _timesCompleted;
        }

        protected void IncreaseTimesCompleted()
        {
            _timesCompleted++;
        }

        public virtual bool IsComplete()
        {
            return _complete;
        }

        protected void MarkComplete()
        {
            _complete = true;
        }

        protected void MarkIncomplete()
        {
            _complete = false;
        }

        // Methods
        public virtual void RecordProgress()
        {
            throw new Exception("Method 'RecordProgress' not available in base class 'Goal'");
        }

        public override string ToString()
        {
            throw new Exception("Method 'ToString' not available in base class 'Goal'");
        }

        public virtual string GetSummary()
        {
            throw new Exception("Method 'GetSummary' not available in base class 'Goal'");
        }

        public virtual string SaveString()
        {
            throw new Exception("Method 'SaveString' not available in base class 'Goal'");
        }
    }
