using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ShellDLL;

namespace ShellTest
{
    class CalculatorShell : Shell
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Shell sh = new CalculatorShell();
            sh.ReadEvalPrint();
        }
    }
}
