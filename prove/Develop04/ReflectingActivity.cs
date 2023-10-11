
    public class ReflectingActivity : Activity
    {
        
        private List<string> _promptList = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        private List<string> _questionList = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        
        public ReflectingActivity()
            : base(
                "Reflecting Activity",
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
            ) { }

        
        public override void Execute()
        {
            StartActivity();
            DisplayPrompt();
            int timeLeft = _duration - 5;
            while (timeLeft >= 5 && _questionList.Count > 0)
            {
                DisplayQuestion();
                timeLeft -= 5;
            }
            EndActivity();
        }

        private void DisplayPrompt() 
        {
            Random tRex = new Random();
            string prompt = _promptList[tRex.Next(_promptList.Count)];
            Console.Write("Consider the following prompt:\n\n");
            Console.Write($"--- {prompt} ---\n\n");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();
            Console.Write(
                "Now, ponder on each of the following questions as they relate to this experience.\n\n"
            );
            Console.Write("Get ready...\n\n");
            LoadingScreen(4);
            Console.Clear();
        }

        private void DisplayQuestion() 
        {
            Random tRex = new Random();
            int randInt = tRex.Next(_questionList.Count);
            string question = _questionList[randInt];
            _questionList.RemoveAt(randInt);
            Console.WriteLine($"> {question}");
            LoadingScreen(5);
        }
    }
