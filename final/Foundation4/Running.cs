namespace Foundation4.Classes
{
    // Define Class
    public class Running : Exercise
    {
        // Attributes
        private double _distance;

        // Constructors
        public Running(string date, int length, double distance)
            : base(date, length, "Running")
        {
            _distance = distance;
        }

        // Methods

        protected override double GetDistance()
        {
            return _distance;
        }

        protected override double GetSpeed()
        {
            return _distance * 60 / _length;
        }

        protected override double GetPace()
        {
            return 60 / GetSpeed();
        }
    }
}