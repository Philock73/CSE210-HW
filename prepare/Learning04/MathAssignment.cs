using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class MathAssignment : Assignment
{

    private string _problemSet;
    
    private double _bookSelection;

    public MathAssignment(string topic, string studentName, double bookSelection, int firstproblem, int secondproblem) : base (topic, studentName)
    {

        _problemSet = firstproblem + "-" + secondproblem;

        _bookSelection = bookSelection;

    } 
        public string GetMathAssignment()
    {
        string list = "";
        list = GetSummary() + " Section " + _bookSelection + ", Problems:" + _problemSet;
        return list;
    }

}
