
    public class Menu
    {
        // Attributes
        public Journal _journal = new Journal();
        public PromptGenerator _prompter = new PromptGenerator();

        // Constructor
        public Menu() { }

        // Methods
        public void StartUp()
        {
            string newNote;
            _prompter.Load();

            Console.WriteLine("Welcome to your Journal app!");
            Console.WriteLine("1. Create new journal\n2. Open journal from file …");
            Console.Write("> ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: // Create new journal
                    Journal newJournal = new Journal();
                    Console.WriteLine("Please enter a name for your Journal: ");
                    Console.Write("> ");
                    newJournal._name = Console.ReadLine();

                    Console.WriteLine(
                        $"Optionally, add any number of notes to {newJournal._name}. Press <return> to add a note. Press <return> on blank to move on."
                    );
                    while (true)
                    {
                        Console.Write("> ");
                        newNote = Console.ReadLine();
                        if (newNote == "")
                        {
                            break;
                        }
                        newJournal.AddNote(newNote);
                    }

                    _journal = newJournal;
                    break;

                case 2: // Open journal from file …
                    Console.WriteLine("Please enter the filename: ");
                    Console.Write("> ");
                    _journal.Load(Console.ReadLine());
                    break;
            }
        }

        public void Run()
        {
            bool runApp = true;
            // string filename;
            // string name;
            string newNote;
            string newPrompt;

            while (runApp)
            {
                Console.WriteLine(
                    $"You are currently accessing {_journal._name}. What would you like to do?"
                );
                Console.WriteLine(
                    "1. Free write\n2. Write from prompt\n3. Display journal\n4. Save file\n5. Save as …\n6. Open file …\n7. Create new journal\n8. Add new note\n9. Add new prompt\n10. Exit"
                );
                Console.Write("> ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: // Free write
                        _journal.CreateFreeWrite();
                        break;

                    case 2: // Write from prompt
                        _journal.CreateFromPrompt(_prompter);
                        break;

                    case 3: // Display journal
                        _journal.Display();
                        break;

                    case 4: // Save file
                        _journal.Save();
                        break;

                    case 5: // Save as …
                        Console.WriteLine("Please enter the filename: ");
                        Console.Write("> ");
                        _journal.SaveAs(Console.ReadLine());
                        break;

                    case 6: // Open file …
                        Console.WriteLine("Please enter the filename: ");
                        Console.Write("> ");
                        _journal.Load(Console.ReadLine());
                        break;

                    case 7: // Create new journal
                        Journal newJournal = new Journal();
                        Console.WriteLine("Please enter a name for your Journal: ");
                        Console.Write("> ");
                        newJournal._name = Console.ReadLine();

                        Console.WriteLine(
                            $"Optionally, add any number of notes to {newJournal._name}. Press <return> to add a note. Press <return> on blank to move on."
                        );
                        while (true)
                        {
                            Console.Write("> ");
                            newNote = Console.ReadLine();
                            if (newNote == "")
                            {
                                break;
                            }
                            newJournal.AddNote(newNote);
                        }

                        _journal = newJournal;
                        break;

                    case 8: // Add new note
                        Console.WriteLine("Enter your note:");
                        Console.Write("> ");
                        newNote = Console.ReadLine();
                        if (newNote != "")
                        {
                            _journal.AddNote(newNote);
                        }
                        break;

                    case 9: // Add new prompt
                        Console.WriteLine("Enter the new prompt:");
                        Console.Write("> ");
                        newPrompt = Console.ReadLine();
                        if (newPrompt != "")
                        {
                            _prompter.AddPrompt(newPrompt);
                        }
                        break;

                    case 10: // Exit
                        Console.WriteLine("You have exited the app.");
                        runApp = false;
                        break;

                    default:
                        break;
                }
            }
        }
    }
