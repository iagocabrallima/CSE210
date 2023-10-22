namespace Foundation4.Classes
{
    // Define Class
    public class Swimming : Exercise
    {
        // Attributes
        private double _laps;

        // Constructors
        public Swimming(string date, int length, double laps)
            : base(date, length, "Swimming")
        {
            _laps = laps;
        }

        // Methods

        protected override double GetDistance()
        {
            return _laps * 0.05;
        }

        protected override double GetSpeed()
        {
            return 60 / GetPace();
        }

        protected override double GetPace()
        {
            return _length / GetDistance();
        }
    }
}
