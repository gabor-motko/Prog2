using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zh1_B
{
    class RC : IComparable<RC>
    {
        public RC(string name, string location, int heightLimit, int waitingTime)
        {
            Name = name;
            Location = location;
            HeightLimit = heightLimit;
            WaitingTime = waitingTime;
        }

        public string Name { get; set; }
        public string Location { get; set; }
        public int HeightLimit { get; set; }
        public int WaitingTime { get; set; }

        public int CompareTo(RC other)
        {
            if (this.WaitingTime != other.WaitingTime)
                return this.WaitingTime.CompareTo(other.WaitingTime);
            if (this.HeightLimit != other.HeightLimit)
                return -this.HeightLimit.CompareTo(other.HeightLimit);
            return this.Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return this.Name + " (" + this.Location + "): " + this.WaitingTime;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            RC[] t = new RC[n];

            for (int i = 0; i < n; ++i)
            {
                string[] line = Console.ReadLine().Split(';');
                t[i] = new RC(line[0], line[1], int.Parse(line[2]), int.Parse(line[3]));
            }

            Array.Sort(t);

            foreach (RC e in t)
                Console.WriteLine(e);
        }
    }
}
