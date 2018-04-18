using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files
{
    class Program
    {
        static string path = "file.txt";
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            try
            {
                using (StreamReader r = new StreamReader(path))
                {
                    string line;
                    while((line = r.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            List<string>.Enumerator e = lines.GetEnumerator();
            while(e.MoveNext())
            {
                Console.WriteLine(e.Current);
            }
            //foreach(var l in lines)
            //{
            //    Console.WriteLine(l);
            //}
        }
    }
}
