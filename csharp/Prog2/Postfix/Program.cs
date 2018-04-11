using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postfix
{
    class Program
    {
        static double Add(double a, double b) => a + b;
        static double Sub(double a, double b) => a - b;
        static double Mult(double a, double b) => a * b;
        static double Div(double a, double b) => a / b;

        delegate double OpDelegate(double a, double b);

        static Dictionary<char, OpDelegate> ops = new Dictionary<char, OpDelegate>()
        {
            {'+', Add },
            {'-', Sub },
            {'*', Mult },
            {'/', Div }
        };

        static double Evaluate(List<string> tokens)
        {
            Stack<double> stack = new Stack<double>();
            foreach (var item in tokens)
            {
                try
                {
                    int i = int.Parse(item);
                    stack.Push(i);
                }
                catch(FormatException)
                {
                    double op1 = stack.Pop();
                    double op2 = stack.Pop();

                    stack.Push(ops[item[0]](op1, op2));
                }
            }
            return stack.Pop();
        }
        
        static void Main(string[] args)
        {
            IList<string> expr = new List<string> { "2", "3", "1", "*", "+", "9", "-" };
            
        }
    }
}
