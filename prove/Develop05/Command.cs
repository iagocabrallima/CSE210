
    // Define class
    public class Command
    {
        // Attributes
        protected Repository _repository;

        // Constructors
        public Command(Repository repo)
        {
            _repository = repo;
        }

        // Methods
        public virtual void Execute()
        {
            throw new Exception("Method 'Execute' not available in base class 'Command'");
        }
    }

