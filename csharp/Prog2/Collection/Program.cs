using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class MyInt : IComparable<MyInt>
    {
        public int Value { get; set; }

        public int CompareTo(MyInt other)
        {
            return this.Value.CompareTo(other.Value);
        }

        public override bool Equals(object obj)
        {
            var @int = obj as MyInt;
            return @int != null &&
                   Value == @int.Value;
        }

        public override int GetHashCode()
        {
            return -1937169414 + Value.GetHashCode();
        }

        public static bool operator ==(MyInt int1, MyInt int2)
        {
            return EqualityComparer<MyInt>.Default.Equals(int1, int2);
        }

        public static bool operator !=(MyInt int1, MyInt int2)
        {
            return !(int1 == int2);
        }
    }
    class TestSet
    {
        static void Main()
        {
            ISet<int> set = new HashSet<int>();
            for (int i = 0; i < 10; ++i)
                set.Add(i + 1);

            ISet<MyInt> set2 = new HashSet<MyInt>();
            for(int i = 0; i < 5; ++i)
            {
                set2.Add(new MyInt { Value = i + 1 });
            }

            ISet<MyInt> set3 = new SortedSet<MyInt>();
            for (int i = 0; i < 5; ++i)
            {
                set2.Add(new MyInt { Value = i + 1 });
            }

            foreach (var i in set3)
                Console.WriteLine(i);
        }
    }
    //class Program
    //{

    //    static void Main(string[] args)
    //    {

    //        IList<int> l = new List<int>();
    //        List<int> l2 = (List<int>)l;
    //        for (int i = 0; i < 10; l.Add(++i)) ;
    //        foreach (int i in l)
    //            Console.WriteLine(i);
    //        Console.WriteLine(l.Contains(2));
    //        l.Remove(2);
    //        Console.WriteLine(l.Contains(2));
    //        l.Insert(1, 2);
    //        Console.WriteLine(l.Contains(2));
    //    }
    //}
}
