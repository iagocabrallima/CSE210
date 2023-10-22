namespace Foundation3.Classes
{
    // Define Class
    class Reception : Event
    {
        // Attributes
        private string _rsvpEmail;
        private int _attendees;

        // Constructors
        public Reception(
            string title,
            string description,
            string date,
            string time,
            Address address,
            string rsvpEmail,
            int attendees
        )
            : base(title, description, date, time, address, "Reception")
        {
            _rsvpEmail = rsvpEmail;
            _attendees = attendees;
        }

        // Methods

        public override string FullDetails()
        {
            return $"{StandardDetails()}\nRSVP to: {_rsvpEmail}";
        }
    }
}