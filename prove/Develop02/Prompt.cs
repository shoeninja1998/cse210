public class Prompt{
    public List<string> _prompts = new(){@"Write about a goal you have for the upcoming week and outline specific steps you can take to achieve it.",
     "Reflect on a mistake you made recently. What did you learn from it, and how can you use that knowledge moving forward?",
     "Imagine your ideal day – from morning to night. Describe it in detail and consider how you can incorporate elements of it into your current life.",
     "Explore a moment of gratitude. What are you thankful for in your life right now?",
     "Reflect on a recent accomplishment that made you proud. Describe the process and emotions involved. ",
     "Write about a challenge you faced today and how you overcame it. What did you learn from the experience? "};

    public string GetRandomPrompt(){
        Random random = new();
        int index = random.Next(0, _prompts.Count);
        return $"{_prompts[index]}";
    }
}