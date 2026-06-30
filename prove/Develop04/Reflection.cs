class Reflection : Exercise
{
    private List<string> _questions = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _responses = new List<string>();

    private int _responsecount;

    public Reflection(int responses, string type, bool complete) : base(type, complete)
    {
        _responsecount = responses;
    }

    public void reflectionProtocal()
    {
        DateTime endTime = CreateExercise();

        Animation myAnimation = new Animation();

        Random random = new Random();

        Console.Clear();

        string question = _questions[random.Next(_questions.Count())];

        Console.WriteLine(question);

        do
        {
            string response = Console.ReadLine();
            _responses.Add(response);

        }while(DateTime.Now < endTime);
        _responsecount = _responses.Count();
        Console.WriteLine($"You wrote {_responsecount} responses!");
        myAnimation.MakeAnimation(3);
        


    }
}