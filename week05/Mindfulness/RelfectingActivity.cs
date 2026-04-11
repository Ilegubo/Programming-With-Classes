namespace MindfulnessProgram
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> _questions = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        public ReflectingActivity()
        {
            _name = "Reflecting Activity";
            _description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
        }

        public void Run()
        {
            DisplayStartingMessage();
            DisplayPrompt();
            Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
            Console.ReadLine();
            
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(10);
            Console.Clear();

            DisplayQuestions();
            DisplayEndingMessage();
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            return _prompts[random.Next(_prompts.Count)];
        }

        public string GetRandomQuestion()
        {
            Random random = new Random();
            return _questions[random.Next(_questions.Count)];
        }

        public void DisplayPrompt()
        {
            Console.WriteLine("\nConsider the following prompt:");
            Console.WriteLine($" --- {GetRandomPrompt()} ---");
        }

        public void DisplayQuestions()
        {
            DateTime endTime = DateTime.Now.AddSeconds(_duration);
            while (DateTime.Now < endTime)
            {
                Console.Write($"> {GetRandomQuestion()} ");
                ShowSpinner(10);
                Console.WriteLine();
            }
        }
    }
}