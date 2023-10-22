namespace Foundation4.Classes
{
    // Define Class
    public class Cycling : Exercise
    {
        // Attributes
        private double _speed;

        // Constructors
        public Cycling(string date, int length, double speed)
            : base(date, length, "Cycling")
        {
            _speed = speed;
        }

        // Methods

        protected override double GetDistance()
        {
            return _speed;
        }

        protected override double GetSpeed()
        {
            return _speed * _length / 60;
        }

        protected override double GetPace()
        {
            return 60 / GetSpeed();
        }
    }
}