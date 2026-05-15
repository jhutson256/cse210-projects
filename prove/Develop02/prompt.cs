using System;

public class jph_Prompt
{
    public List<string> _jphPrompts = new List<string>();

    public void PromptGenerator()
    {
        _jphPrompts.Add("Who was the most interesting person I interacted with today?");
        _jphPrompts.Add("What was the best part of my day?");
        _jphPrompts.Add("How did I see the hand of the Lord in my life today?");
        _jphPrompts.Add("What was the strongest emotion I felt today?");
        _jphPrompts.Add("If I had one thing I could do over today, what would it be?");
    }

    public string GetPrompt()
    {
        PromptGenerator();
        Random jph_randomGenerator = new Random();
        int jph_index = jph_randomGenerator.Next(_jphPrompts.Count);
        string jph_randomPrompt = _jphPrompts[jph_index];

        return jph_randomPrompt;
    }
}