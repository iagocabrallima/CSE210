using System.IO;


    // Define class
    public class Repository
    {
        // Attributes
        private List<Goal> _goals = new List<Goal>();
        private string _filename = "goals.txt";

        // Constructor
        public Repository() { }

        // Methods
        public List<Goal> GetAll()
        {
            return _goals;
        }

        public void Add(Goal goal)
        {
            _goals.Add(goal);
        }

        public void Remove(Goal goal)
        {
            _goals.Remove(goal);
        }

        public void Save()
        {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.SaveString());
                }
            }
            Console.Write("Your goals have been saved. ");
            EnterToReturn();
        }

        public void Load()
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);
            List<Goal> loadedGoals = new List<Goal>();
            foreach (string line in lines)
            {
                string[] data = line.Split("##");
                string goalType = data[0];
                string name = data[1];
                string description = data[2];
                int points = int.Parse(data[3]);
                int earned = int.Parse(data[4]);
                int timesCompleted = int.Parse(data[5]);
                bool isComplete = Boolean.Parse(data[6]);
                switch (goalType)
                {
                    case "1":
                    {
                        Goal goal = new SimpleGoal(
                            name,
                            description,
                            points,
                            earned,
                            timesCompleted,
                            isComplete
                        );
                        loadedGoals.Add(goal);
                        break;
                    }
                    case "2":
                    {
                        Goal goal = new EternalGoal(
                            name,
                            description,
                            points,
                            earned,
                            timesCompleted,
                            isComplete
                        );
                        loadedGoals.Add(goal);
                        break;
                    }
                    case "3":
                    {
                        int timesToComplete = int.Parse(data[7]);
                        int completionBonus = int.Parse(data[8]);
                        Goal goal = new ChecklistGoal(
                            name,
                            description,
                            points,
                            earned,
                            timesCompleted,
                            isComplete,
                            timesToComplete,
                            completionBonus
                        );
                        loadedGoals.Add(goal);
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
            _goals = loadedGoals;
            Console.Write("Your goals have been loaded. ");
            Display();
            EnterToReturn();
        }

        public void Display()
        {
            Console.WriteLine($"There are {GetAll().Count} goals in the system.");
            int goalCounter = 1;
            foreach (Goal goal in GetAll())
            {
                Console.Write($"{goalCounter}. ");
                Console.WriteLine(goal.ToString());
                goalCounter++;
            }
        }

        public void RecordGoalProgress()
        {
            Display();
            Console.WriteLine("Which goal did you complete?");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;
            Goal goal = GetAll()[goalIndex];
            goal.RecordProgress();
            Console.WriteLine(goal.GetSummary());
            EnterToReturn();
        }

        public void EnterToReturn()
        {
            Console.Write("Press enter to return to the main menu.\n> ");
            Console.ReadLine();
        }

        public int GetTotalPoints()
        {
            int totalPoints = 0;
            foreach (Goal goal in GetAll())
            {
                totalPoints += goal.GetEarned();
            }
            return totalPoints;
        }

        public void ListGoals()
        {
            Display();
            Console.Write($"You have earned a total of {GetTotalPoints()} points! ");
            EnterToReturn();
        }
    }
