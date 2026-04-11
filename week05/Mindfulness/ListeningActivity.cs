namespace MindfulnessProgram
{
    public class ListingActivity : Activity
    {
        private int _count;
        private List<string> _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are some of your personal heroes?"
        };

        public ListingActivity()
        {
            _name = "Listing Activity";
            _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can.";
        }

        public void Run()
        {
            DisplayStartingMessage();
            GetRandomPrompt(); // Displays the prompt

            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();

            List<string> items = GetListFromUser();
            _count = items.Count;

            Console.WriteLine($"You listed {_count} items!");
            DisplayEndingMessage();
        }

        public void GetRandomPrompt()
        {
            Random random = new Random();
            Console.WriteLine("\nList as many responses as you can to the following prompt:");
            Console.WriteLine($" --- {_prompts[random.Next(_prompts.Count)]} ---");
        }

        public List<string> GetListFromUser()
        {
            List<string> userList = new List<string>();
            DateTime endTime = DateTime.Now.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input))
                {
                    userList.Add(input);
                }
            }
            return userList;
        }
    }
}