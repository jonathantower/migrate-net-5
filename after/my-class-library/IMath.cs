using System.Collections.Generic;

namespace Demo.ClassLibrary
{
    public interface IMath
    {
        int Add(int AddNumber1, int AddNumber2);
        int Subtract(int SubtractNumber1, int SubtractNumber2);
        int Multiply(int MultiplyNumber1, int MultiplyNumber2);
        int Divide(int DivideNumber1, int DivideNumber2);
        IEnumerable<string> FamousMathematicians();
    }
}