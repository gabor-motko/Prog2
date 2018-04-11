﻿using System;
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

        Dictionary<char, OpDelegate> ops = new Dictionary<char, OpDelegate>()
        {
            {'+', Add },
            {'-', Sub },
            {'*', Mult },
            {'/', Div }
        };

        static int Evaluate(List<string> tokens)
        {
            Stack<double> stack = new Stack<double>();
            foreach (var item in tokens)
            {
                try
                {
                    int i = int.Parse(item);
                }
                catch(FormatException ex)
                {

                }
            }
        }
        
        static void Main(string[] args)
        {
            IList<string> expr = new List<string> { "2", "3", "1", "*", "+", "9", "-" };
            
        }
    }
}
