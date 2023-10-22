namespace Foundation3.Classes
{
    // Define Class
    class Lecture : Event
    {
        // Attributes
        private string _speaker;
        private int _capacity;

        // Constructors
        public Lecture(
            string title,
            string description,
            string date,
            string time,
            Address address,
            string speaker,
            int capacity
        )
            : base(title, description, date, time, address, "Lecture")
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        // Methods

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nSpeaker: {_speaker}\nMax Capacity: {_capacity}";
        }
    }
}