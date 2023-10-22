namespace Foundation3.Classes
{
    // Define Class
    class Command
    {
        // Constructors
        public Command() { }

        // Methods

        public virtual void Execute()
        {
            throw new Exception("Method 'Execute' not available in base class 'Command'");
        }
    }
}