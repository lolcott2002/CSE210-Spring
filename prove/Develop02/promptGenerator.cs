using System;
public class promptGenerator
{
    public List<string> _prompts = new List<string>();
    public string GeneratePrompt()
    {
        List prompts = new List<string>();
        prompts.Add("What was the worst and best part of your day?");
        prompts.Add("What did you learn today?");
        prompts.Add("If you could change one thing about your day, what would it be?");
        prompts.Add("How did you work on yourself today?");
        prompts.Add("What are you grateful for today?");
        return prompts[new Random().Next(prompts.Count)];
    }

}