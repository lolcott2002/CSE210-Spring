using System;
using System.Collections.Generic; 

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What was the worst and best part of your day?",
        "What did you learn today?",
        "If you could change one thing about your day, what would it be?",
        "How did you work on yourself today?",
        "What are you grateful for today?",
        "Write about whatever you want."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count); 
        return _prompts[index]; 
    }
}