using System;
using System.Collections.Generic;

class PromptGenerator
{
    static string _First = "What was the best thing that happened today?";
    static string _Second = "If you could improve on something today, what would that be?";
    static string _Third = "What happened today that made you realize the hand of God in your life?";
    static string _Fourth = "What would you do to draw close to God?";
    static string _Fifth = "In what way did you show or experience love today?";
    static List<string> _Prompts = new List<string> {_First, _Second, _Third, _Fourth, _Fifth};
    string SelectPrompt()
    {
        Random randomIndex = new Random();
        string _prompt = _Prompts[randomIndex.Next(_Prompts.Count)];
        Console.WriteLine(_prompt);
        return _prompt;
    }
}