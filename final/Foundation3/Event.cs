namespace Foundation3.Classes
{
    // Define Class
    class Event
    {
        // Attributes
        private string _title;
        private string _description;
        private string _date;
        private string _time;
        private Address _address;
        private string _eventType;

        // Constructors
        public Event(
            string title,
            string description,
            string date,
            string time,
            Address address,
            string eventType
        )
        {
            _title = title;
            _eventType = eventType;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        // Methods

        public string StandardDetails()
        {
            return $"{_title}\n{_description}\nWhere: {_address.ToString()}\nWhen: {_date} @ {_time}";
        }

        public virtual string FullDetails()
        {
            throw new Exception("Method 'FullDetails' not available in base class 'Event'");
        }

        public string ShortDetails()
        {
            return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date}";
        }
    }
}