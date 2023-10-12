using System.IO;

    // Define class
    public class Entry
    {
        // Attributes
        public string _dateTime = "";
        public string _prompt = "";
        public string _body = "";

        // Constructor
        public Entry() { }

        // Methods
        public void Display()
        {
            Console.WriteLine(_dateTime);
            if (_prompt != "none")
            {
                Console.WriteLine("Prompt: " + _prompt);
            }
            Console.WriteLine(_body);
        }

        public Entry SaveTo(StreamWriter outputFile)
        {
            outputFile.WriteLine("##ENTRY");
            outputFile.WriteLine(_dateTime);
            outputFile.WriteLine(_prompt);
            outputFile.WriteLine(_body);
            // outputFile.WriteLine("END##");
            return this;
        }
    }
