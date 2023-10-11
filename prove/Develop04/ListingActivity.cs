
    public class ListingActivity : Activity
    {
        
        private List<string> _promptList = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        private List<string> _responsesList = new List<string>();

        
        public ListingActivity()
            : base(
                "Listing Activity",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
            ) { }

        
        public override void Execute()
        {
            StartActivity();
            DisplayPrompt();
            int timeLeft = _duration - 5;
            UserListsItems(timeLeft);
            DisplayNumItems();
            EndActivity();
        }

        private void DisplayPrompt() 
        {
            Random tRex = new Random();
            string prompt = _promptList[tRex.Next(_promptList.Count)];
            Console.Write("List as many responses as you can for the following prompt:\n\n");
            Console.Write($"--- {prompt} ---\n\n");
            Console.Write("Get ready...\n\n");
            CountDownFrom(5);
            Console.Clear();
            Console.Write($"--- {prompt} ---\n\n");
        }

        private List<string> UserListsItems(int seconds) 
        {
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                _responsesList.Add(Console.ReadLine());
            }
            return _responsesList;
        }

        private void DisplayNumItems() 
        {
            Console.Write($"\nYou listed {_responsesList.Count} items!\n\n");
            LoadingScreen(4);
        }
    }
