
    public class BreathingActivity : Activity
    {

        public BreathingActivity()
            : base(
                "Breathing Activity",
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
            ) { }

        
        public override void Execute()
        {
            StartActivity();
            int timeLeft = _duration;
            while (timeLeft > 6)
            {
                BreatheInAndOut();
                timeLeft -= 10;
            }
            EndActivity();
        }

        private void BreatheInAndOut()
        {
            Console.Write("Breathe in...");
            CountDownFrom(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            CountDownFrom(5);
            Console.Write("\n\n");
        }
    }
