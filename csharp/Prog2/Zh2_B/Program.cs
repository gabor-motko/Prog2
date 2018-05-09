using System;
using System.Collections.Generic;

namespace Zh2_B
{
    class Program
    {
        static Dictionary<string, string> dict = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                string[] tok = line.Split(' ');
                if (tok.Length == 1)
                {
                    if (dict.ContainsKey(tok[0]))
                    {
                        Console.WriteLine(dict[tok[0]]);
                    }
                    else
                    {
                        Console.WriteLine("unknown");
                    }
                }
                else if (tok.Length == 2)
                {
                    if (dict.ContainsKey(tok[0]))
                    {
                        if (dict[tok[0]].Length > tok[1].Length)
                            dict[tok[0]] = tok[1];
                    }
                    else
                    {
                        dict.Add(tok[0], tok[1]);
                    }
                }
                else
                {

                }
            }
        }
    }
}
