namespace Foundation3.Classes
{
    // Define Class
    class CreateReceptionCommand : Command
    {
        // Constructors
        public CreateReceptionCommand()
            : base() { }

        // Methods

        public override void Execute()
        {
            Address address = new Address("141 Wallaby Way", "Sidney", "Queensland", "Australia");
            Reception reception = new Reception(
                "Alex & Takota's Wedding Reception",
                "Come join us for a wonderful night of celebration for the wedding of these two fantastic people!",
                "July 22",
                "6:00 pm",
                address,
                "taco_tuesday@rosengrenfamily.com",
                50
            );

            Console.WriteLine(reception.StandardDetails() + "\n");
            Console.WriteLine(reception.FullDetails() + "\n");
            Console.WriteLine(reception.ShortDetails() + "\n");
        }
    }
}