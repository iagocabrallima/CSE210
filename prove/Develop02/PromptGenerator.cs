using System.IO;

    // Define class
    public class PromptGenerator
    {
        // Attributes
        public string _filename = "Resources/Prompts.txt";
        public List<string> _promptList = new List<string>();

        // Constructor
        public PromptGenerator() { }

        // Methods
        public string GetRandom()
        {
            Random tRex = new Random();
            string prompt = _promptList[tRex.Next(_promptList.Count)];
            return prompt;
        }

        public string AddPrompt(string prompt)
        {
            _promptList.Add(prompt);
            this.Save();
            return prompt;
        }

        public PromptGenerator Save() //string filename=_filename)
        {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                foreach (var prompt in _promptList)
                {
                    outputFile.WriteLine(prompt);
                }
            }

            // _filename = filename;
            return this;
        }

        public PromptGenerator Load() //string filename=_filename)
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach (var line in lines)
            {
                _promptList.Add(line.Trim());
            }

            // _filename = filename;
            return this;
        }
    }
