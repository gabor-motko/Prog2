using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh1_D
{
    class Program
    {
        enum Operator { None, And, Or, Implication, Equivalence }
        static void Main(string[] args)
        {
            string line;
            Operator op = Operator.None;
            while ((line = Console.ReadLine()) != null)
            {
                string[] s = line.Split(' ');
                if (line[0] == '1' || line[0] == '0')    //interpretáció
                {
                    bool a = s[0] == "1";
                    bool b = s[1] == "1";
                    switch (op)
                    {
                        case Operator.None:
                            break;
                        case Operator.And:
                            Console.WriteLine(a && b ? '1' : '0');
                            break;
                        case Operator.Or:
                            Console.WriteLine(a || b ? '1' : '0');
                            break;
                        case Operator.Implication:
                            Console.WriteLine((a == true && b == false) ? '0' : '1');
                            break;
                        case Operator.Equivalence:
                            Console.WriteLine(a == b ? '1' : '0');
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    //formula
                    Console.WriteLine(line);
                    switch (s[1])
                    {
                        case "=":
                            op = Operator.Equivalence;
                            break;
                        case ">":
                            op = Operator.Implication;
                            break;
                        case "&":
                            op = Operator.And;
                            break;
                        case "|":
                            op = Operator.Or;
                            break;
                        default:
                            op = Operator.None;
                            break;
                    }
                }
            }
        }
    }
}
