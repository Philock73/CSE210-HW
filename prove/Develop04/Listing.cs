class Listing : Exercise
{
    private int _timing;
    private List<string> myThoughts = new List<string>
    {
      "Think of a time when you stood up for someone else.",
      "Think of a time when you did something really difficult.",
      "Think of a time when you helped someone in need.",
      "Think of a time when you did something truly selfless."
    };

    private List<string> myQuestions = new List<string>
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

    public Listing(int timing, string type, bool complete) : base(type, complete)
  {
    _timing = timing;
  }

  public void listingProtocal()
  {
    int completion = CreateExercise();

    Random randomQuestion = new Random();

    Animation waiting = new Animation();

    DateTime now = DateTime.Now;
    
    DateTime endTime = now.AddSeconds(completion + 1);

    string question = myThoughts[randomQuestion.Next(myThoughts.Count())];

    Console.Clear();

    Console.WriteLine(question);

      do{  

        Console.WriteLine(myQuestions[randomQuestion.Next(myQuestions.Count())]);
        
        waiting.MakeAnimation(_timing);
        
        Console.Clear();
        
        Console.WriteLine(question);

      }while(DateTime.Now < endTime);


  }

}