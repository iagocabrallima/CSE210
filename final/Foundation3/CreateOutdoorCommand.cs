namespace Foundation3.Classes
{
    // Define Class
    class CreateOutdoorCommand : Command
    {
        // Constructors
        public CreateOutdoorCommand()
            : base() { }

        // Methods

        public override void Execute()
        {
            Address address = new Address("Buckingham Palace", "London", "England", "UK");
            Outdoor outdoor = new Outdoor(
                "Nebeker Family Reunion",
                "The craziest thing since the T-Rex. Be there or be square!",
                "June 29",
                "4:00 am",
                address,
                "sunny with 60% chance of smiles"
            );

            Console.WriteLine(outdoor.StandardDetails() + "\n");
            Console.WriteLine(outdoor.FullDetails() + "\n");
            Console.WriteLine(outdoor.ShortDetails() + "\n");
        }
    }
}