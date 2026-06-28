class Exercise
{
    private int _amountofTime;

    private string _type;

    private bool _complete;

    public Exercise()
    {
        _amountofTime = 0;

        _type = " ";
        
        _complete = false;

    }

    public Exercise(string type, bool complete)
    {
        _type = type;

        _complete = complete;

    }
    public int CreateExercise()
    {
        int seconds;
        do
        {
            Console.WriteLine($"{_type} Exercise: ");
            Console.Write("How long do you want to do this exercise for?\n> ");
            seconds = int.Parse(Console.ReadLine());
        
            if(seconds > 0 | seconds < 99)
            {
                _amountofTime = seconds;
            }
            else
            {
                Console.WriteLine("Incorrect values, please try again. \n> ");
                
            }
        }while(seconds < 0 | seconds > 99);
        return _amountofTime;
    }
}