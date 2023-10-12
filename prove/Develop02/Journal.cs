using System.IO;

    public class Journal
    {
        // Attributes
        public string _name = "";
        public string _filename = "";
        public List<string> _notes = new List<string>();
        public List<Entry> _entryList = new List<Entry>();

        // Constructor
        public Journal() { }

        // Methods
        public void Display()
        {
            Console.WriteLine($"\nJournal: {_name}\n");

            Console.WriteLine("Notes:");
            foreach (var note in _notes)
            {
                Console.WriteLine(note);
            }
            Console.WriteLine();

            foreach (var entry in _entryList)
            {
                entry.Display();
                Console.WriteLine("");
            }
        }

        public Journal Load(string filename)
        {
            this._name = "";
            this._filename = filename;
            this._notes.Clear();
            this._entryList.Clear();

            string[] lines = System.IO.File.ReadAllLines($"Journals/{filename}.txt");

            string importDest = "";

            for (int i = 0; i < lines.Length; i++)
            {
                string stripped = lines[i].Trim();

                if (stripped == "##NAME")
                {
                    importDest = "name";
                }
                else if (stripped == "##NOTES")
                {
                    importDest = "notes";
                }
                else if (stripped == "##ENTRY")
                {
                    importDest = "entry";

                    Entry eImporter = new Entry();
                    eImporter._dateTime = lines[i + 1].Trim();
                    eImporter._prompt = lines[i + 2].Trim();
                    eImporter._body = lines[i + 3].Trim();

                    this._entryList.Add(eImporter);
                }
                else if (importDest == "name")
                {
                    this._name = stripped;
                }
                else if (importDest == "notes")
                {
                    this._notes.Add(stripped);
                }
            }

            return this;
        }

        public Journal SaveAs(string filename)
        {
            using (StreamWriter outputFile = new StreamWriter($"Journals/{filename}.txt"))
            {
                outputFile.WriteLine("##NAME");
                outputFile.WriteLine(_name);

                outputFile.WriteLine("##NOTES");
                foreach (var note in _notes)
                {
                    outputFile.WriteLine(note);
                }

                foreach (var entry in _entryList)
                {
                    entry.SaveTo(outputFile);
                }
            }
            return this;
        }

        public Journal Save()
        {
            string filename = "";
            if (_filename == "")
            {
                Console.WriteLine("Please enter a filename:");
                Console.Write("> ");
                filename = Console.ReadLine();
            }
            else
            {
                filename = _filename;
            }
            this.SaveAs(filename);
            return this;
        }

        public Entry CreateFreeWrite()
        {
            Entry entry = new Entry();

            entry._prompt = "none";
            Console.WriteLine("Write whatever you'd like. Hit <return> to finish.");
            Console.Write("> ");
            entry._body = Console.ReadLine();

            DateTime currentTime = DateTime.Now;
            entry._dateTime = currentTime.ToString("g");

            _entryList.Add(entry);
            return entry;
        }

        public Entry CreateFromPrompt(PromptGenerator prompter)
        {
            Entry entry = new Entry();

            entry._prompt = prompter.GetRandom();
            Console.WriteLine(entry._prompt);
            Console.Write("> ");
            entry._body = Console.ReadLine();

            DateTime currentTime = DateTime.Now;
            entry._dateTime = currentTime.ToString("g");

            _entryList.Add(entry);
            return entry;
        }

        public void AddNote(string newNote)
        {
            _notes.Add(newNote);
        }
    }
