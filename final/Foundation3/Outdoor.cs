namespace Foundation3.Classes
{
    // Define Class
    class Outdoor : Event
    {
        // Attributes
        private string _weatherForecast;

        // Constructors
        public Outdoor(
            string title,
            string description,
            string date,
            string time,
            Address address,
            string weatherForecast
        )
            : base(title, description, date, time, address, "Outdoor")
        {
            _weatherForecast = weatherForecast;
        }

        // Methods

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nThe weather is expected to be {_weatherForecast}";
        }
    }
}