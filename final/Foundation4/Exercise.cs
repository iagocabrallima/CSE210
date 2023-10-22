
    // Define Class
    public class Exercise
    {
        // Attributes
        private string _date;
        protected int _length;
        private string _exerciseType;

        // Constructors
        public Exercise(string date, int length, string exerciseType)
        {
            _date = date;
            _length = length;
            _exerciseType = exerciseType;
        }

        // Methods

        protected virtual double GetDistance()
        {
            throw new Exception("Method 'GetDistance' not available in base class 'Exercise");
        }

        protected virtual double GetSpeed()
        {
            throw new Exception("Method 'GetSpeed' not available in base class 'Exercise");
        }

        protected virtual double GetPace()
        {
            throw new Exception("Method 'GetPace' not available in base class 'Exercise");
        }

        public string GetSummary()
        {
            return $"{_date} {_exerciseType} ({_length} min): Distance {GetDistance().ToString("0.0")} km, Speed: {GetSpeed().ToString("0.0")} kph, Pace: {GetPace().ToString("0.0")} min per km";
        }
    }
