using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LatinSquare
{
    class Program
    {
        static bool LSCheck(int[,] m, int n)
        {
            bool[] exists = new bool[n + 1];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    exists[m[i, j]] = true;
                }

                for(int j = 1; j <= n; ++j)
                {
                    if (!exists[j])
                        return false;
                }
            }
            for (int j = 0; j < n; ++j)
            {
                for (int i = 0; i < n; ++i)
                {
                    exists[m[i, j]] = true;
                }

                for (int i = 1; i <= n; ++i)
                {
                    if (!exists[i])
                        return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            using (TextReader r = new StreamReader(args[0]))
            {
                string line = null;
                int n = 0;
                while ((line = r.ReadLine()) != null)
                {
                    n = int.Parse(line);
                    int[,] m = new int[n, n];
                    //int[][] m = new int[n][];
                    for (int i = 0; i < n; ++i)
                    {
                        string[] temp = r.ReadLine().Split(' ');
                        //m[i] = Array.ConvertAll(temp, int.Parse);
                        for (int j = 0; j < n; ++j)
                        {
                            m[i, j] = int.Parse(temp[j]);
                        }
                    }
                    Console.Write(LSCheck(m, n) ? "YES\n" : "NO\n");
                }
            }
        }
    }
}
